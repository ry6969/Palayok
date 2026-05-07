using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Palayok.UI
{
    public partial class ReadOnlyCookingScreen : RecipeAwareScreen
    {
        public ReadOnlyCookingScreen()
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
                "Adobo" => Properties.Resources.ReadAdobo,
                "Tinola" => Properties.Resources.ReadTinola,
                "Tortang Talong" => Properties.Resources.ReadTorta,
                "Paksiwan Bangus" => Properties.Resources.ReadPaksiw,
                "Pork Monggo" => Properties.Resources.ReadMonggo,
                "Nilagang Baka" => Properties.Resources.ReadNilaga,
                _ => null
            };
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
