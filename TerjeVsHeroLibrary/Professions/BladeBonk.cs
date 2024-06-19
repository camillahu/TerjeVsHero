using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerjeVsHeroLibrary.Interfaces;

namespace TerjeVsHeroLibrary.Professions
{
    public class BladeBonk : ICommand, IProfession
    {
        public string Label => "Blade Bonk";
        public int Option => 2;
        public int Energy  => 10;
        public int StrengthModifier => 10;

        public string AskForOptionAndLabel()
        {
            return $"{Option}. {Label}";   
        }

        public List<string> ProfessionAbilityName { get; }
            = new List<string>()
            {
                new("Bonk"),
                new("Crush"),
            };
        public List<string> ProfessionAbilitiesReadier { get; }
            = new List<string>()
            {
                new("You blunt your blade on a rock to ready it for a devastating bonk on your next turn"),
                new("You ready your blade for a crushing ankle blow"),
            };

         public List<string> ProfessionAbilitiesAttack { get; }
            = new List<string>()
            {
                new("You bonk the enemy on the head"),
                new("You crush your enemys ankle"),
            };
        public string GetProfessionAbilityReadier(int index)
        {
            return ProfessionAbilitiesReadier[index];
        }
        public string GetProfessionAbilityAttack(int index)
        {
            return ProfessionAbilitiesAttack[index];
        }

    }
}
