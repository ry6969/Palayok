using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Palayok.UI
{
    public partial class ModeScreen : BaseScreen
    {
        public ModeScreen()
        {
            InitializeComponent();
            universalBackBtn1.BackClicked += (s, e) => OnBackClicked();
        }

        private void RTCMode_Click(object sender, EventArgs e)
        {
            RaiseNavigate("InteractiveCookingScreen");
        }

        private void ROMode_Click(object sender, EventArgs e)
        {
            RaiseNavigate("ReadOnlyCookingScreen");
        }
    }
}
