using System;
using System.Collections.Generic;
using System.Text;

namespace Palayok.Models
{
    public class Recipe
    {
        public string Name { get; set; }
        public List<Step> Steps { get; set; } = new List<Step>();
    }
}
