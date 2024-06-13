using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerjeVsHeroLibrary.Interfaces;

namespace TerjeVsHeroLibrary.Races
{
    public class Fairy : Race, ICommand
    {
        public string Label => "Fairy";

        public int Option => 1;

        public string AskForOptionAndLabel()
        {
            return $"{Option}. {Label}";
        }
    }
}
