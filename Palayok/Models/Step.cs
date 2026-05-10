using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;

namespace Palayok.Models
{
    public abstract class Step
    {
        public int StepNumber { get; set; } = 1;
        public string GifPath { get; set; }  // Path to the step GIF
        public string BtnPath { get; set; } // Path to the button image for this step
        public string AudioEffect { get; set; } // Audio effect to play (e.g., "Frying", "Cooking", "Chopping")
    }
}
