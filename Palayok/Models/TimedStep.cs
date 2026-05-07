using System;
using System.Collections.Generic;
using System.Text;

namespace Palayok.Models
{
    internal class TimedStep
    {
        public int DurationInSeconds { get; private set; }
        public bool AutoAdvance { get; private set; }
    }
}
