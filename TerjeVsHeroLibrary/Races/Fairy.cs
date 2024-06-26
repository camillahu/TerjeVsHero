using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerjeVsHeroLibrary.Interfaces;

namespace TerjeVsHeroLibrary.Races
{
    public class Fairy : Race
    {
        //public string Label => "Fairy";
        //public int Option => 1;
        //public double DexterityModifier => 5;
        //public double HPModifier => 5;
        //public string RacialAbilityAttack => "Flying attack";

        public Fairy()
        {
            Label = "Fairy";
            Option = 1;
            DexterityModifier = 5;
            HPModifier = 5;
            RacialAbilityAttack = "Flying attack";
        }

        //public string AskForOptionAndLabel()
        //{
        //    return $"{Option}. {Label}";
        //}


        public override string GetRacialAbilityAttack()
        {
            return "You fly into the air and attack the enemy from above";
        }
    }
}
