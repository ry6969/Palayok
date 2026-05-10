using System;
using System.Collections.Generic;
using System.Text;

namespace Palayok.UI
{
    internal class ScreenFactory
    {
        public UserControl CreateScreen(string destination, object data = null)
        {
            UserControl screen = destination switch
            {
                "StartScreen" => new StartScreen(),
                "ModeScreen" => new ModeScreen(),
                "RecipeSelectionScreen" => new RecipeSelectionScreen(),
                "InteractiveCookingScreen" => new InteractiveCookingScreen(),
                "ReadOnlyCookingScreen" => new ReadOnlyCookingScreen(),
                "LoadingScreen" => new LoadingScreen(),
                "ViewIngredients" => new ViewIngredients(),
                _ => throw new ArgumentException($"Unknown Destination: {destination}")
            };

            // Pass data to screens that need it
            if (screen is RecipeSelectionScreen recipeScreen && data is not null)
            {
                // Handle recipe data if needed
            }

            return screen;
        }
    }
}
