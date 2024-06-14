using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerjeVsHeroLibrary.Interfaces;

namespace TerjeVsHeroLibrary.Races
{
    public class Fairy : IRace, ICommand
    {
        public string Label => "Fairy";

        public int Option => 1;

        public double Dexterity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double HP { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string AskForOptionAndLabel()
        {
            return $"{Option}. {Label}";
        }
    }
}
