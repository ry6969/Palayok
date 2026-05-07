using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Palayok.UI
{
    public class BaseScreen : UserControl
    {
        public event Action<string, object> OnNavigate;
        public event EventHandler BackClicked;

        public BaseScreen()
        {
            BackColor = Color.Transparent;
            DoubleBuffered = true;
        }

        protected void RaiseNavigate(string mode, object data = null)
        {
            if (mode != "")
            {
                OnNavigate?.Invoke(mode, data);
            }
        }

        protected void OnBackClicked()
        {
            BackClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
