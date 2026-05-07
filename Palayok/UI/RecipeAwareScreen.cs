using System;
using System.Collections.Generic;
using System.Text;

namespace Palayok.UI
{
    public class RecipeAwareScreen : BaseScreen
    {
        protected string CurrentRecipe { get; set; }

        public virtual void SetRecipe(string recipe)
        {
            CurrentRecipe = recipe;
        }
    }
}
