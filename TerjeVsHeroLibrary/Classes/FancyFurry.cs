using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp20;
using TerjeVsHeroLibrary.Interfaces;

namespace TerjeVsHeroLibrary.Classes
{
    internal class FancyFurry : Hero ICommand
    {
        public FancyFurry(string name) : base(name)
        {
        }

        public string Label => "Fancy furry";
        public int Option => 1;
        public string AskForOptionAndLabel()
        {
            return $"{Option}. {Label}";   
        }
    }
}
