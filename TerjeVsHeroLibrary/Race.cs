using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerjeVsHeroLibrary.Interfaces;

namespace TerjeVsHeroLibrary
{
    public abstract class Race : IRace, ICommand
    {
        public double DexterityModifier { get; set; }
        public double HPModifier { get; set; }
        public string RacialAbilityAttack { get; set; }

        public abstract string GetRacialAbilityAttack();
        public string Label { get; set; }
        public int Option { get; set; }
        public string AskForOptionAndLabel()
        {
            return $"{Option}. {Label}";
        }
    }
}
