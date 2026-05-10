using System;
using System.Windows.Forms;
using Palayok.Audio;

namespace Palayok.UI
{
    public partial class MuteBtn : UserControl
    {
        public MuteBtn()
        {
            InitializeComponent();
            this.Load += MuteBtn_Load;
        }

        private void MuteBtn_Load(object sender, EventArgs e)
        {
            UpdateMuteIcon();

            // Listen for mute state changes
            AudioManager.OnMuteChanged += AudioManager_OnMuteChanged;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AudioManager.ToggleMute();
        }

        private void AudioManager_OnMuteChanged(bool muted)
        {
            UpdateMuteIcon();
        }

        private void UpdateMuteIcon()
        {
            button1.Image = AudioManager.IsMuted
                ? Properties.Resources.Unmute
                : Properties.Resources.Mute;
        }
    }
}