using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Palayok.UI;

namespace Palayok
{
    public partial class MainForm : Form
    {
        private ScreenFactory screenFactory = new ScreenFactory();
        private Stack<string> navigationHistory = new Stack<string>();
        private Stack<object> navigationDataHistory = new Stack<object>();
        private string currentScreen;
        private object navigationData;
        private Panel screenPanel;
        private string selectedRecipe;  // Store selected recipe

        public MainForm()
        {
            InitializeComponent();
            InitializeScreenPanel();

            // Load the Start Screen
            currentScreen = "StartScreen";
            LoadScreen(screenFactory.CreateScreen(currentScreen));
        }

        private void InitializeScreenPanel()
        {
            screenPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = System.Drawing.Color.White
            };
            Controls.Add(screenPanel);
        }

        public void HandleNavigation(string destination, object data = null)
        {
            if (destination != currentScreen)
            {
                navigationHistory.Push(currentScreen);
                navigationDataHistory.Push(navigationData);
            }

            // Store recipe if passed
            if (data is string recipe)
            {
                selectedRecipe = recipe;
            }

            currentScreen = destination;
            navigationData = data;
            LoadScreen(screenFactory.CreateScreen(destination, data), data);
        }

        public void HandleBack()
        {
            if (navigationHistory.Count > 0)
            {
                string previousScreen = navigationHistory.Pop();
                object previousData = navigationDataHistory.Count > 0 ? navigationDataHistory.Pop() : null;
                currentScreen = previousScreen;
                navigationData = previousData;
                LoadScreen(screenFactory.CreateScreen(currentScreen, previousData), previousData);
            }
        }

        public void LoadScreen(UserControl screen, object data = null)
        {
            screenPanel.Controls.Clear();
            screen.Dock = DockStyle.Fill;

            if (screen is BaseScreen baseScreen)
            {
                baseScreen.OnNavigate += (destination, navData) => HandleNavigation(destination, navData);
                baseScreen.BackClicked += (s, e) => HandleBack();
            }

            // Pass stored recipe to any recipe-aware screen
            if (screen is RecipeAwareScreen recipeScreen && selectedRecipe != null)
            {
                recipeScreen.SetRecipe(selectedRecipe);
            }

            screenPanel.Controls.Add(screen);
        }

        private void Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
