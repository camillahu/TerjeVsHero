using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Dette er den som tidligere het "Class", for å velge klasse (typ fancy furry, pyromancer, osv)

namespace TerjeVsHeroLibrary.Interfaces
{
    public interface IProfession
    {
        int Energy { get; } // kalle den EnergyModifier? Nei
        int StrengthModifier { get; }
    }
}
