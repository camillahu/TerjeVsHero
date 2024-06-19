using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerjeVsHeroLibrary.Interfaces;

namespace TerjeVsHeroLibrary
{
    public abstract class Race : IRace
    {
        public double DexterityModifier { get; }
        public double HPModifier { get; }
        public string RacialAbilityAttack { get; }

        public abstract string GetRacialAbilityAttack();
    }
}
