using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerjeVsHeroLibrary.Interfaces
{
    public interface IProfession
    {
        int Energy { get; set; } // kalle den EnergyModifier?
        int StrengthModifier { get; set; }
    }
}
