﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerjeVsHeroLibrary.Interfaces
{
    public interface IRace
    {
        public double DexterityModifier { get; }
        public double HPModifier { get; }

        string RacialAbilityAttack { get; }
        string GetRacialAbilityAttack(); 
    }
}
