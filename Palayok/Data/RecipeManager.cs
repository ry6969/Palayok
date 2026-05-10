using System;
using System.Collections.Generic;
using System.Text;
using Palayok.Models;

namespace Palayok.Data
{
    public static class RecipeManager
    {
        // Helper class to define step configuration
        private class StepConfig
        {
            public string? Button { get; set; }
            public int? DurationInSeconds { get; set; } // null = BasicStep, value = TimedStep
            public bool AutoAdvance { get; set; }
            public string? AudioEffect { get; set; } // Optional audio effect (e.g., "Frying", "Cooking")
        }

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

        // Helper method to add steps to a recipe
        private static void AddStepsToRecipe(Recipe recipe, string recipeFolder, StepConfig[] steps)
        {
            for (int i = 0; i < steps.Length; i++)
            {
                int stepNumber = i + 1;
                string gifPath = $"Resources/InteractiveScreens/{recipeFolder}/{stepNumber}{recipeFolder}.gif";
                string btnPath = $"Resources/Buttons/{steps[i].Button}.png";

                if (steps[i].DurationInSeconds.HasValue)
                {
                    // Add as TimedStep
                    recipe.Steps.Add(new TimedStep
                    {
                        StepNumber = stepNumber,
                        GifPath = gifPath,
                        BtnPath = btnPath,
                        DurationInSeconds = steps[i].DurationInSeconds.Value,
                        AutoAdvance = steps[i].AutoAdvance,
                        AudioEffect = steps[i].AudioEffect
                    });
                }
                else
                {
                    // Add as BasicStep
                    recipe.Steps.Add(new BasicStep
                    {
                        StepNumber = stepNumber,
                        GifPath = gifPath,
                        BtnPath = btnPath,
                        AudioEffect = steps[i].AudioEffect
                    });
                }
            }
        }

        private static Recipe CreateAdoboRecipe()
        {
            var recipe = new Recipe { Name = "Adobo" };

            var adoboSteps = new[]
            {
                new StepConfig { Button = "LetsGo"},
                new StepConfig { Button = "Chop", AudioEffect = "Chopping" },
                new StepConfig { Button = "Next" },
                new StepConfig { Button = "Chop", AudioEffect = "Chopping" },
                new StepConfig { Button = "Next" },
                new StepConfig { Button = "Chop", AudioEffect = "Chopping" },
                new StepConfig { Button = "Next" },
                new StepConfig { Button = "Cook" },
                new StepConfig { Button = "Add" },
                new StepConfig { Button = "Add", AudioEffect = "Frying" },
                new StepConfig { Button = "Add", AudioEffect = "Frying" },
                new StepConfig { Button = "Cook", AudioEffect = "Frying" },
                new StepConfig { Button = "Cook", AudioEffect = "Frying" },
                new StepConfig { Button = "StartTimer", AudioEffect = "Sprinkling" }, // 14Adobo
                new StepConfig { Button = "Done", DurationInSeconds = 5, AutoAdvance = false, AudioEffect = "Timer" },
                new StepConfig { Button = "Cook", AudioEffect = "Pouring" }, // 16Adobo
                new StepConfig { Button = "Cook", AudioEffect = "Pouring" }, // 17Adobo
                new StepConfig { Button = "StartTimer", AudioEffect = "Pouring" }, // 18Adobo
                new StepConfig { Button = "Done", DurationInSeconds = 1800, AutoAdvance = false, AudioEffect = "Timer" }, // 19Adobo
                new StepConfig { Button = "Done" }
            };

            AddStepsToRecipe(recipe, "Adobo", adoboSteps);
            return recipe;
        }

        private static Recipe CreateTinolaRecipe()
        {
            var recipe = new Recipe { Name = "Tinola" };

            var tinolaSteps = new[]
            {
                new StepConfig { Button = "LetsGo" },
                new StepConfig { Button = "Chop", AudioEffect = "Chopping" }, // 2Tinola
                new StepConfig { Button = "Next" },
                new StepConfig { Button = "Chop", AudioEffect = "Chopping" }, // 4Tinola
                new StepConfig { Button = "Next" },
                new StepConfig { Button = "Chop", AudioEffect = "Chopping" }, // 6Tinola
                new StepConfig { Button = "Next" },
                new StepConfig { Button = "Chop", AudioEffect = "Chopping" }, // 8Tinola
                new StepConfig { Button = "Next" },
                new StepConfig { Button = "Pick", AudioEffect = "Picking" }, // 10Tinola
                new StepConfig { Button = "Next" },
                new StepConfig { Button = "Chop", AudioEffect = "Chopping" }, // 12Tinola
                new StepConfig { Button = "Next" },
                new StepConfig { Button = "Cook", AudioEffect = "Chopping" }, // 14Tinola
                new StepConfig { Button = "Add" },
                new StepConfig { Button = "Add" },
                new StepConfig { Button = "Done", AudioEffect = "Frying" }, // 18Tinola
                new StepConfig { Button = "Done", AudioEffect = "Frying" }, // 19Tinola
                new StepConfig { Button = "Next", AudioEffect = "Frying" }, // 20Tinola
                new StepConfig { Button = "Add" },
                new StepConfig { Button = "Add" },
                new StepConfig { Button = "Add" },
                new StepConfig { Button = "Add", AudioEffect = "Sprinkling" }, // 24Tinola
                new StepConfig { Button = "Pour", AudioEffect = "Sprinkling" }, // 25Tinola
                new StepConfig { Button = "Cook", AudioEffect = "Pouring" }, // 26Tinola
                new StepConfig { Button = "StartTimer", AudioEffect = "Boiling" }, // 27Tinola
                new StepConfig { Button = "Serve", DurationInSeconds = 1800, AutoAdvance = false, AudioEffect = "Timer" }, // 28Tinola
                new StepConfig { Button = "Done" } // 29Tinola
            };

            AddStepsToRecipe(recipe, "Tinola", tinolaSteps);
            return recipe;
        }

        private static Recipe CreateTortangTalongRecipe()
        {
            var recipe = new Recipe { Name = "Tortang Talong" };

            var tortangSteps = new[]
            {
                new StepConfig { Button = "LetsGo" },
                new StepConfig { Button = "StartTimer", AudioEffect = "Steaming" }, // 2Torta
                new StepConfig { Button = "Flip", DurationInSeconds = 300, AutoAdvance = false, AudioEffect = "Timer" },
                new StepConfig { Button = "Done" },
                new StepConfig { Button = "Peel", AudioEffect = "Peeling2" }, // 5Torta
                new StepConfig { Button = "Add" },
                new StepConfig { Button = "Put", AudioEffect = "Sprinkling" }, // 7Torta
                new StepConfig { Button = "Done" },
                new StepConfig { Button = "Add" },
                new StepConfig { Button = "Add", AudioEffect = "Frying" }, // 10Torta
                new StepConfig { Button = "StartTimer", AudioEffect = "Frying" }, // 11Torta
                new StepConfig { Button = "Done", DurationInSeconds = 600, AutoAdvance = false, AudioEffect = "Timer" },
                new StepConfig { Button = "Serve" },
                new StepConfig { Button = "Done", AudioEffect = "Cooked" } // 14Torta
            };

            AddStepsToRecipe(recipe, "Torta", tortangSteps);
            return recipe;
        }

        private static Recipe CreatePaksiwanBangusRecipe()
        {
            var recipe = new Recipe { Name = "Paksiwan Bangus" };

            var bangusSteps = new[]
            {
                new StepConfig { Button = "LetsGo" },
                new StepConfig { Button = "Slice", AudioEffect = "Chopping" }, // 2Paksiw
                new StepConfig { Button = "Next" },
                new StepConfig { Button = "Chop", AudioEffect = "Chopping" }, // 4Paksiw
                new StepConfig { Button = "Next" },
                new StepConfig { Button = "Slice", AudioEffect = "Chopping" }, // 6Paksiw
                new StepConfig { Button = "Next" },
                new StepConfig { Button = "Cook" },
                new StepConfig { Button = "Arrange" },
                new StepConfig { Button = "Add" },
                new StepConfig { Button = "Add", AudioEffect = "Pouring" }, // 11Paksiw
                new StepConfig { Button = "Cover", AudioEffect = "Sprinkling" }, // 12Paksiw
                new StepConfig { Button = "StartTimer", AudioEffect = "Steaming" }, // 14Paksiw
                new StepConfig { Button = "Serve", DurationInSeconds = 1800, AutoAdvance = false, AudioEffect = "Timer" },
                new StepConfig { Button = "Done", AudioEffect = "Cooked" } // 15Paksiw
            };

            AddStepsToRecipe(recipe, "Paksiw", bangusSteps);
            return recipe;
        }

        private static Recipe CreatePorkMonggoRecipe()
        {
            var recipe = new Recipe { Name = "Pork Monggo" };

            var monggoSteps = new[]
            {
                new StepConfig { Button = "LetsGo" },
                new StepConfig { Button = "LetsGo" },
                new StepConfig { Button = "Pluck", AudioEffect = "Picking" }, // 3Monggo
                new StepConfig { Button = "Next" },
                new StepConfig { Button = "Chop", AudioEffect = "Chopping" }, // 5Monggo
                new StepConfig { Button = "Next" },
                new StepConfig { Button = "Chop", AudioEffect = "Chopping" }, // 7Monggo
                new StepConfig { Button = "Next" },
                new StepConfig { Button = "Chop", AudioEffect = "Chopping" }, // 9Monggo
                new StepConfig { Button = "Next" },
                new StepConfig { Button = "Slice", AudioEffect = "Chopping" }, // 11Monggo
                new StepConfig { Button = "Next" },
                new StepConfig { Button = "Cook" },
                new StepConfig { Button = "LetsGo" },
                new StepConfig { Button = "Pour" },
                new StepConfig { Button = "Pour", AudioEffect = "Pouring" }, // 16Monggo
                new StepConfig { Button = "Cover" },
                new StepConfig { Button = "StartTimer" },
                new StepConfig { Button = "Serve", DurationInSeconds = 3600, AutoAdvance = false, AudioEffect = "Timer" }, // 19Monggo
                new StepConfig { Button = "Add" },
                new StepConfig { Button = "Add" },
                new StepConfig { Button = "Saute", AudioEffect = "Frying" }, // 22Monggo
                new StepConfig { Button = "Add", AudioEffect = "Frying" }, // 23Monggo
                new StepConfig { Button = "Add", AudioEffect = "Frying" }, // 24Monggo
                new StepConfig { Button = "Add", AudioEffect = "Frying" }, // 25Monggo
                new StepConfig { Button = "Cook", AudioEffect = "Frying" }, // 26Monggo
                new StepConfig { Button = "Pour", AudioEffect = "Frying" }, // 27Monggo
                new StepConfig { Button = "Next", DurationInSeconds = 300, AutoAdvance = false, AudioEffect = "Timer" }, // 28Monggo
                new StepConfig { Button = "Next", AudioEffect = "Frying" }, // 29Monggo
                new StepConfig { Button = "Pour" },
                new StepConfig { Button = "Cover" },
                new StepConfig { Button = "StartTimer" },
                new StepConfig { Button = "Add", DurationInSeconds = 900, AutoAdvance = false, AudioEffect = "Timer" }, // 33Monggo
                new StepConfig { Button = "StartTimer", AudioEffect = "Steaming" }, // 34Monggo
                new StepConfig { Button = "Serve", DurationInSeconds = 60, AutoAdvance = false, AudioEffect = "Timer" }, // 35Monggo
                new StepConfig { Button = "Done", AudioEffect = "Cooked" } // 36Monggo
            };

            AddStepsToRecipe(recipe, "Monggo", monggoSteps);
            return recipe;
        }

        private static Recipe CreateNilagangBakaRecipe()
        {
            var recipe = new Recipe { Name = "Nilagang Baka" };

            var bakaSteps = new[]
            {
                new StepConfig { Button = "LetsGo" },
                new StepConfig { Button = "Cut", AudioEffect = "Chopping" }, // 2Nilaga
                new StepConfig { Button = "Next" },
                new StepConfig { Button = "Cut", AudioEffect = "Chopping" }, // 4Nilaga
                new StepConfig { Button = "Next" },
                new StepConfig { Button = "Pick", AudioEffect = "Chopping" }, // 6Nilaga
                new StepConfig { Button = "Smash" },
                new StepConfig { Button = "Next" },
                new StepConfig { Button = "Peel", AudioEffect = "Peeling2" }, // 9Nilaga
                new StepConfig { Button = "Cut", AudioEffect = "Chopping" }, // 10Nilaga
                new StepConfig { Button = "Next" },
                new StepConfig { Button = "Cut", AudioEffect = "Chopping" }, // 12Nilaga
                new StepConfig { Button = "Next" },
                new StepConfig { Button = "Cut", AudioEffect = "Chopping" }, // 14Nilaga
                new StepConfig { Button = "Next" },
                new StepConfig { Button = "Cook" },
                new StepConfig { Button = "Next" },
                new StepConfig { Button = "Pour", AudioEffect = "Pouring" }, // 18Nilaga
                new StepConfig { Button = "Add" },
                new StepConfig { Button = "Add" },
                new StepConfig { Button = "Cover" },
                new StepConfig { Button = "StartTimer" },
                new StepConfig { Button = "Next", DurationInSeconds = 5400, AutoAdvance = false, AudioEffect = "Timer" }, // 23Nilaga
                new StepConfig { Button = "Add", AudioEffect = "Steaming" }, // 24Nilaga
                new StepConfig { Button = "Add", AudioEffect = "Steaming" }, // 25Nilaga
                new StepConfig { Button = "Cover", AudioEffect = "Steaming" }, // 26Nilaga
                new StepConfig { Button = "StartTimer", AudioEffect = "Steaming" }, // 27Nilaga
                new StepConfig { Button = "Next", DurationInSeconds = 600, AutoAdvance = false, AudioEffect = "Timer" }, // 28Nilaga
                new StepConfig { Button = "Add", AudioEffect = "Steaming" }, // 29Nilaga
                new StepConfig { Button = "Cover", AudioEffect = "Steaming" }, // 30Nilaga
                new StepConfig { Button = "StartTimer", AudioEffect = "Steaming" }, // 31Nilaga
                new StepConfig { Button = "Serve", DurationInSeconds = 180, AutoAdvance = false, AudioEffect = "Timer" }, // 32Nilaga
                new StepConfig { Button = "Done", AudioEffect = "Cooked" } // 33Nilaga
            };

            AddStepsToRecipe(recipe, "Nilaga", bakaSteps);
            return recipe;
        }
    }
}
