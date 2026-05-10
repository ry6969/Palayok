using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Palayok.Models;
using Palayok.Data;
using Palayok.Audio;

namespace Palayok.UI
{
    public partial class InteractiveCookingScreen : RecipeAwareScreen
    {
        private Recipe currentRecipeData;
        private int currentStepIndex = 0;
        private int timeRemaining = 0;
        private bool isTimerRinging = false;

        public InteractiveCookingScreen()
        {
            InitializeComponent();
            universalBackBtn1.BackClicked += (s, e) => OnBackClicked();

            // Setup timer
            timer1.Interval = 1000; // 1 second
            timer1.Tick += Timer1_Tick;
        }

        public override void SetRecipe(string recipe)
        {
            base.SetRecipe(recipe);                    // Stores "Adobo" in CurrentRecipe
            LoadRecipeSteps(recipe);                   // Loads the recipe data
            DisplayStep(0);                            // Shows first step

            // Play background music for cooking screen
            AudioManager.PlayBackgroundMusic("Track2", true);
        }

        private void LoadRecipeSteps(string recipeName)
        {
            currentRecipeData = RecipeManager.GetRecipe(recipeName);
            currentStepIndex = 0;
        }

        private void DisplayStep(int stepIndex)
        {
            AudioManager.StopAllSoundEffects();

            if (currentRecipeData?.Steps != null && stepIndex >= 0 && stepIndex < currentRecipeData.Steps.Count)
            {
                currentStepIndex = stepIndex;
                Step step = currentRecipeData.Steps[stepIndex];

                try
                {
                    // Always stop timer first when displaying new step
                    timer1.Stop();
                    label1.Text = "";

                    // Build correct path from bin folder to project root Resources folder
                    string basePath = AppDomain.CurrentDomain.BaseDirectory;
                    string projectRoot = Path.GetFullPath(Path.Combine(basePath, "..", "..", ".."));

                    // Load step GIF
                    string gifPath = Path.Combine(projectRoot, step.GifPath);
                    pictureBox2.Image = Image.FromFile(gifPath);

                    // Load button image
                    if (!string.IsNullOrEmpty(step.BtnPath))
                    {
                        string btnPath = Path.Combine(projectRoot, step.BtnPath);
                        NextBtn.Image = Image.FromFile(btnPath);
                    }

                    // Check if this is a timed step
                    if (step is TimedStep timedStep)
                    {
                        // This is a timed step - handle timer logic
                        int durationSeconds = timedStep.DurationInSeconds;
                        bool autoAdvance = timedStep.AutoAdvance;

                        // Start the timer
                        timeRemaining = durationSeconds;
                        label1.Text = FormatTime(timeRemaining);
                        timer1.Start();

                        // Play audio effect if defined
                        if (!string.IsNullOrEmpty(timedStep.AudioEffect))
                        {
                            AudioManager.PlaySoundEffect(timedStep.AudioEffect);
                        }
                    }
                    else
                    {
                        // This is a basic step
                        // Play audio effect if defined
                        if (!string.IsNullOrEmpty(step.AudioEffect))
                        {
                            AudioManager.PlaySoundEffect(step.AudioEffect);
                        }
                    }

                    // TODO: Update UI with step number, description, etc.
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to load step image: {ex.Message}");
                }
            }
        }

        private void NextStep()
        {
            if (currentStepIndex < currentRecipeData.Steps.Count - 1)
            {
                DisplayStep(currentStepIndex + 1);
            }
            else
            {
                AudioManager.StopBackgroundMusic();
                AudioManager.PlaySoundEffect("Cooked");
                MessageBox.Show("You have completed the recipe! \nPress OK to return to the start screen.");
                RaiseNavigate("StartScreen");
            }
        }

        //Implement if needed
        private void PreviousStep()
        {
            if (currentStepIndex > 0)
            {
                DisplayStep(currentStepIndex - 1);
            }
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            AudioManager.PlaySoundEffect("Click");
            NextStep();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timeRemaining--;
            label1.Text = FormatTime(timeRemaining);

            if (timeRemaining <= 0)
            {
                timer1.Stop();

                Step currentStep = currentRecipeData.Steps[currentStepIndex];

                if (!isTimerRinging)
                {
                    isTimerRinging = true;

                    AudioManager.StopAllSoundEffects();
                    AudioManager.PlaySoundEffect("TimerEnd");

                    // 🔁 re-trigger loop manually every 5 seconds
                    System.Windows.Forms.Timer ringTimer = new System.Windows.Forms.Timer();
                    ringTimer.Interval = 5000; // match your sound length
                    ringTimer.Tick += (s, ev) =>
                    {
                        AudioManager.PlaySoundEffect("TimerEnd");
                    };
                    ringTimer.Start();
                }

                if (currentStep is TimedStep timedStep && timedStep.AutoAdvance)
                {
                    isTimerRinging = false;
                    NextStep();
                }
            }
        }

        private string FormatTime(int seconds)
        {
            int minutes = seconds / 60;
            int secs = seconds % 60;
            return $"{minutes:D2}:{secs:D2}";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
