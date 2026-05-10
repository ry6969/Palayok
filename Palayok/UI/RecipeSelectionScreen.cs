using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Palayok.Audio;

namespace Palayok.UI
{
    public partial class RecipeSelectionScreen : RecipeAwareScreen
    {
        private string? selectedRecipe = null;

        public RecipeSelectionScreen()
        {
            InitializeComponent();
            AttachButtonHandlers();
            universalBackBtn1.BackClicked += (s, e) => OnBackClicked();


        }

        private void AttachButtonHandlers()
        {
            Recipe1Btn.Click += (s, e) => { AudioManager.PlaySoundEffect("Click"); SelectRecipe("Adobo"); };
            Recipe2Btn.Click += (s, e) => { AudioManager.PlaySoundEffect("Click"); SelectRecipe("Tinola"); };
            Recipe3Btn.Click += (s, e) => { AudioManager.PlaySoundEffect("Click"); SelectRecipe("Tortang Talong"); };
            Recipe4Btn.Click += (s, e) => { AudioManager.PlaySoundEffect("Click"); SelectRecipe("Paksiwan Bangus"); };
            Recipe5Btn.Click += (s, e) => { AudioManager.PlaySoundEffect("Click"); SelectRecipe("Pork Monggo"); };
            Recipe6Btn.Click += (s, e) => { AudioManager.PlaySoundEffect("Click"); SelectRecipe("Nilagang Baka"); };
        }

        private void SelectRecipe(string recipeName)
        {
            selectedRecipe = recipeName;
            CurrentRecipe = recipeName;  // Also update base class property

            if (recipeName.Contains(" "))
            {
                // Multi-word recipe - format as multiline with smaller font
                ChosenLabel.Font = new Font(ChosenLabel.Font.FontFamily, 20f);
                var parts = recipeName.Split(' ');
                ChosenLabel.Text = $": {parts[0]}\n{parts[1]}";
            }
            else
            {
                // Single word recipe - use larger font
                ChosenLabel.Font = new Font(ChosenLabel.Font.FontFamily, 32f);
                ChosenLabel.Text = $": {recipeName}";
            }
        }

        private void ViewIngredientsBtn_Click(object sender, EventArgs e)
        {
            AudioManager.PlaySoundEffect("Click");
            if (selectedRecipe != null)
            {
                RaiseNavigate("ViewIngredients", selectedRecipe);
            }
        }

        public override void SetRecipe(string recipe)
        {
            base.SetRecipe(recipe);
            SelectRecipe(recipe);
        }

        private void universalBackBtn1_Load(object sender, EventArgs e)
        {

        }

        private void CookBtn_Click(object sender, EventArgs e)
        {
            AudioManager.PlaySoundEffect("Click");
            if (selectedRecipe != null)
            {
                RaiseNavigate("ModeScreen", selectedRecipe);
            }
        }

        private void muteBtn1_Load(object sender, EventArgs e)
        {

        }
    }
}
