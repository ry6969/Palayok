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
    public partial class LoadingScreen : BaseScreen
    {
        public LoadingScreen()
        {
            InitializeComponent();
        }

        private async void LoadingScreen_Load(object sender, EventArgs e)
        {
            try
            {
                // Subscribe to audio loading progress
                AudioManager.OnLoadingProgress += AudioManager_OnLoadingProgress;

                // Load audio asynchronously
                await System.Threading.Tasks.Task.Run(() => AudioManager.LoadAllAudio());

                // Check if audio loaded successfully
                if (AudioManager.IsAudioLoaded)
                {
                    System.Diagnostics.Debug.WriteLine("Audio loaded successfully!");
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Warning: Audio may not have loaded properly!");
                }

                // Keep loading screen visible for at least 2 seconds
                await System.Threading.Tasks.Task.Delay(2000);

                // After audio is loaded, navigate to StartScreen
                RaiseNavigate("StartScreen");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in LoadingScreen_Load: {ex.Message}");
                MessageBox.Show($"Error loading audio: {ex.Message}");
            }
        }

        private void AudioManager_OnLoadingProgress(string message)
        {
            // Log progress to debug output
            System.Diagnostics.Debug.WriteLine($"Audio Loading: {message}");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}


