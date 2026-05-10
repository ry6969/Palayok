using System;
using System.Collections.Generic;
using System.Text;

namespace Palayok.Models
{
    public class TimedStep : Step
    {
        public int DurationInSeconds { get; set; }
        public bool AutoAdvance { get; set; }
    }
}
