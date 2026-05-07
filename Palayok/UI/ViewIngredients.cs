using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Palayok.UI
{
    public partial class ViewIngredients : RecipeAwareScreen
    {
        public ViewIngredients()
        {
            InitializeComponent();
            universalBackBtn1.BackClicked += (s, e) => OnBackClicked();
        }

        public override void SetRecipe(string recipe)
        {
            base.SetRecipe(recipe);
            DisplayIngredients(recipe);
        }

        private void DisplayIngredients(string recipeName)
        {
            // Display ingredients based on recipe name
            pictureBox1.Image = recipeName switch
            {
                "Adobo" => Properties.Resources.ViewAdobo,
                "Tinola" => Properties.Resources.ViewTinola,
                "Tortang Talong" => Properties.Resources.ViewTorta,
                "Paksiwan Bangus" => Properties.Resources.ViewPaksiw,
                "Pork Monggo" => Properties.Resources.ViewMonggo,
                "Nilagang Baka" => Properties.Resources.ViewNilaga,
                _ => null
            };
        }

        private void ViewIngredients_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
