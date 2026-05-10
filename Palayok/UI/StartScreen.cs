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
    public partial class StartScreen : BaseScreen
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        private void StartScreen_Load(object sender, EventArgs e)
        {
            // Play background music
            AudioManager.PlayBackgroundMusic("Track1", true);
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            AudioManager.PlaySoundEffect("Click");
            RaiseNavigate("RecipeSelectionScreen");
        }
    }
}

