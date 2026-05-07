using System;
using System.Collections.Generic;
using System.Text;
using Palayok.Models;

namespace Palayok.Data
{
    public static class RecipeManager
    {
        public static Recipe GetRecipe(string recipeName)
        {
            return recipeName switch
            {
                "Adobo" => CreateAdoboRecipe(),
                "Tinola" => CreateTinolaRecipe(),
                "Tortang Talong" => CreateTortangTalongRecipe(),
                "Paksiwan Bangus" => CreatePaksiwanBangusRecipe(),
                "Pork Monggo" => CreatePorkMonggoRecipe(),
                "Nilagang Baka" => CreateNilagangBakaRecipe(),
                _ => null
            };
        }

        private static Recipe CreateAdoboRecipe()
        {
            var recipe = new Recipe { Name = "Adobo" };

            // Array of button names for each step (20 steps total)
            string[] adoboButtons = new[]
            {
                "LetsGo",    // Step 1
                "Chop",      // Step 2
                "Next",      // Step 3
                "Chop",      // Step 4
                "Next",      // Step 5
                "Chop",      // Step 6
                "Next",      // Step 7
                "Cook",      // Step 8
                "Add",       // Step 9
                "Add",       // Step 10
                "Add",       // Step 11
                "Cook",      // Step 12
                "Cook",      // Step 13
                "StartTimer",// Step 14
                "Done",      // Step 15
                "Cook",      // Step 16
                "Cook",      // Step 17
                "StartTimer",// Step 18
                "Done",      // Step 19
                "Done"       // Step 20
            };

            // Add all 20 steps for Adobo
            for (int i = 1; i <= 20; i++)
            {
                recipe.Steps.Add(new BasicStep
                {
                    StepNumber = i,
                    GifPath = $"Resources/InteractiveScreens/Adobo/{i}Adobo.gif",
                    BtnPath = $"Resources/Buttons/{adoboButtons[i - 1]}.png"
                });
            }

            return recipe;
        }

        private static Recipe CreateTinolaRecipe()
        {
            var recipe = new Recipe { Name = "Tinola" };

            // Array of button names for each step (28 steps total)
            string[] tinolaButtons = new[]
            {
                "LetsGo",    // Step 1
                "Chop",      // Step 2
                "Next",      // Step 3
                "Chop",      // Step 4
                "Next",      // Step 5
                "Chop",      // Step 6
                "Next",      // Step 7
                "Chop",      // Step 8
                "Next",      // Step 9
                "Pick",      // Step 10
                "Next",      // Step 11
                "Chop",      // Step 12
                "Next",      // Step 13
                "Cook",      // Step 14
                "Add",       // Step 15
                "Add",       // Step 16
                "Done",      // Step 17
                "Done",      // Step 18
                "Next",      // Step 19
                "Add",       // Step 20
                "Add",       // Step 21
                "Add",       // Step 22
                "Add",       // Step 23
                "Pour",      // Step 24
                "Cook",      // Step 25
                "StartTimer",// Step 26
                "Serve",     // Step 27
                "Done"       // Step 28
            };

            // Add all 28 steps for Tinola
            for (int i = 1; i <= 28; i++)
            {
                recipe.Steps.Add(new BasicStep
                {
                    StepNumber = i,
                    GifPath = $"Resources/InteractiveScreens/Tinola/{i}Tinola.gif",
                    BtnPath = $"Resources/Buttons/{tinolaButtons[i - 1]}.png"
                });
            }

            return recipe;
        }

        private static Recipe CreateTortangTalongRecipe()
        {
            var recipe = new Recipe { Name = "Tortang Talong" };
            // Array of button names for each step (13 steps total)
            string[] tortangButtons = new[]
            {
                "LetsGo",    // Step 1
                "StartTimer",// Step 2
                "Flip",      // Step 3
                "Done",      // Step 4
                "Peel",      // Step 5
                "Add",       // Step 6
                "Put",       // Step 7
                "Done",      // Step 8
                "Add",       // Step 9
                "Add",       // Step 10
                "StartTimer",// Step 11
                "Done",      // Step 12
                "Serve",     // Step 13
                "Done"       // Step 14
            };

            // Add all 14 steps for Tortang Talong
            for (int i = 1; i <= 14; i++)
            {
                recipe.Steps.Add(new BasicStep
                {
                    StepNumber = i,
                    GifPath = $"Resources/InteractiveScreens/TortangTalong/{i}Torta.gif",
                    BtnPath = $"Resources/Buttons/{tortangButtons[i - 1]}.png"
                });
            }

            return recipe;
        }

        private static Recipe CreatePaksiwanBangusRecipe()
        {
            var recipe = new Recipe { Name = "Paksiwan Bangus" };
            // Array of button names for each step (15 steps total)
            string[] bangusButtons = new[]
            {
                "LetsGo",    // Step 1
                "Slice",     // Step 2
                "Next",      // Step 3
                "Chop",      // Step 4
                "Next",      // Step 5
                "Slice",     // Step 6
                "Next",      // Step 7
                "Cook",      // Step 8
                "Arrange",   // Step 9
                "Add",       // Step 10
                "Add",       // Step 11
                "Cover",     // Step 12
                "StartTimer",// Step 13
                "Serve",     // Step 14
                "Done"       // Step 15
            };

            // Add all 15 steps for Paksiwan Bangus
            for (int i = 1; i <= 15; i++)
            {
                recipe.Steps.Add(new BasicStep
                {
                    StepNumber = i,
                    GifPath = $"Resources/InteractiveScreens/PaksiwNaBangus/{i}Paksiw.gif",
                    BtnPath = $"Resources/Buttons/{bangusButtons[i - 1]}.png"
                });
            }

            return recipe;
        }

        private static Recipe CreatePorkMonggoRecipe()
        {
            var recipe = new Recipe { Name = "Pork Monggo" };
            // Array of button names for each step (36 steps total)
            string[] monggoButtons = new[]
            {
                "LetsGo",    // Step 1
                "LetsGo",    // Step 2
                "Pluck",     // Step 3
                "Next",      // Step 4
                "Chop",      // Step 5
                "Next",      // Step 6
                "Chop",      // Step 7
                "Next",      // Step 8
                "Chop",      // Step 9
                "Next",      // Step 10
                "Slice",     // Step 11
                "Next",      // Step 12
                "Cook",      // Step 13
                "LetsGo",    // Step 14
                "Pour",      // Step 15
                "Pour",      // Step 16
                "Cover",     // Step 17
                "StartTimer",// Step 18
                "Serve",     // Step 19
                "Add",       // Step 20
                "Add",       // Step 21
                "Saute",     // Step 22
                "Add",       // Step 23
                "Add",       // Step 24
                "Add",       // Step 25
                "Cook",      // Step 26
                "Pour",      // Step 27
                "Next",      // Step 28
                "Next",      // Step 29
                "Pour",      // Step 30
                "Cover",     // Step 31
                "StartTimer",// Step 32
                "Add",       // Step 33
                "StartTimer",// Step 34
                "Serve",     // Step 35
                "Done"       // Step 36
            };

            // Add all 36 steps for Pork Monggo
            for (int i = 1; i <= 36; i++)
            {
                recipe.Steps.Add(new BasicStep
                {
                    StepNumber = i,
                    GifPath = $"Resources/InteractiveScreens/PorkMonggo/{i}Monggo.gif",
                    BtnPath = $"Resources/Buttons/{monggoButtons[i - 1]}.png"
                });
            }
            return recipe;
        }

        private static Recipe CreateNilagangBakaRecipe()
        {
            var recipe = new Recipe { Name = "Nilagang Baka" };
            // Array of button names for each step (31 steps total)
            string[] bakaButtons = new[]
            {
                "LetsGo",    // Step 1
                "Cut",       // Step 2
                "Next",      // Step 3
                "Cut",       // Step 4
                "Next",      // Step 5
                "Pick",      // Step 6
                "Smash",     // Step 7
                "Next",      // Step 8
                "Peel",      // Step 9
                "Cut",       // Step 10
                "Next",      // Step 11
                "Cut",       // Step 12
                "Next",      // Step 13
                "Cut",       // Step 14
                "Next",      // Step 15
                "Cook",      // Step 16
                "Next",      // Step 17
                "Pour",      // Step 18
                "Add",       // Step 19
                "Add",       // Step 20
                "Cover",     // Step 21
                "StartTimer",// Step 22
                "Next",      // Step 23
                "Add",       // Step 24
                "Add",       // Step 25
                "Cover",     // Step 26
                "StartTimer",// Step 27
                "Next",      // Step 28
                "Add",       // Step 29
                "Cover",     // Step 30
                "StartTimer",// Step 31
                "Serve",     // Step 32
                "Done"       // Step 33
            };

            // Add all 33 steps for Nilagang Baka
            for (int i = 1; i <= 33; i++)
            {
                recipe.Steps.Add(new BasicStep
                {
                    StepNumber = i,
                    GifPath = $"Resources/InteractiveScreens/NilagangBaka/{i}Nilaga.gif",
                    BtnPath = $"Resources/Buttons/{bakaButtons[i - 1]}.png"
                });
            }
            return recipe;
        }
    }
}
