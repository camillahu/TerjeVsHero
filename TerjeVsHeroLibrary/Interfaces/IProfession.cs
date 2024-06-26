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
        int Energy { get; } 
        int StrengthModifier { get; }

        List<string> ProfessionAbilityName { get; }

        List<string> ProfessionAbilitiesReadier { get; }

        List<string> ProfessionAbilitiesAttack { get; }

        string GetProfessionAbilityReadier(int index);

        string GetProfessionAbilityAttack(int index);
    }
}
