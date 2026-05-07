using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Palayok.Models;
using Palayok.Data;

namespace Palayok.UI
{
    public partial class InteractiveCookingScreen : RecipeAwareScreen
    {
        private Recipe currentRecipeData;
        private int currentStepIndex = 0;

        public InteractiveCookingScreen()
        {
            InitializeComponent();
            universalBackBtn1.BackClicked += (s, e) => OnBackClicked();
        }

        public override void SetRecipe(string recipe)
        {
            base.SetRecipe(recipe);                    // Stores "Adobo" in CurrentRecipe
            LoadRecipeSteps(recipe);                   // Loads the recipe data
            DisplayStep(0);                            // Shows first step
        }

        private void LoadRecipeSteps(string recipeName)
        {
            currentRecipeData = RecipeManager.GetRecipe(recipeName);
            currentStepIndex = 0;
        }

        private void DisplayStep(int stepIndex)
        {
            if (currentRecipeData?.Steps != null && stepIndex >= 0 && stepIndex < currentRecipeData.Steps.Count)
            {
                currentStepIndex = stepIndex;
                Step step = currentRecipeData.Steps[stepIndex];

                try
                {
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
            } else 
            {
                MessageBox.Show("You have completed the recipe!"); 
            }
        }

        private void PreviousStep()
        {
            if (currentStepIndex > 0)
            {
                DisplayStep(currentStepIndex - 1);
            }
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            NextStep();

        }
    }
}
