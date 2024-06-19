using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerjeVsHeroLibrary.Interfaces;

namespace TerjeVsHeroLibrary.Races
{
    public class Fairy : Race, IRace, ICommand
    {
        public string Label => "Fairy";
        public int Option => 1;
        public double DexterityModifier => 5;
        public double HPModifier => 5;

        public string AskForOptionAndLabel()
        {
            return $"{Option}. {Label}";
        }

        public string RacialAbilityAttack => "Flying attack";

        public override string GetRacialAbilityAttack()
        {
            return "You fly into the air and attack the enemy from above";
        }
    }
}
