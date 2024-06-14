using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp20;
using TerjeVsHeroLibrary.Interfaces;

namespace TerjeVsHeroLibrary.Classes
{
    internal class FancyFurry : Hero, ICommand
    {
        public FancyFurry(string name = "Fancy Furry")
        {
        }

        public string Label => "Fancy Furry";
        public int Option => 1;
        public int StrengthModifier => 5;
        public int Energy => 15;
        public string AskForOptionAndLabel()
        {
            return $"{Option}. {Label}";   
        }
    }
}
