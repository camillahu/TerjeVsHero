using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerjeVsHeroLibrary.Interfaces;

namespace TerjeVsHeroLibrary
{
    public abstract class Profession : IProfession, ICommand
    {
        public int Energy { get; set; }
        public int StrengthModifier { get; set; }
        public List<string> ProfessionAbilityName { get; set; }
        public List<string> ProfessionAbilitiesReadier { get; set; }
        public List<string> ProfessionAbilitiesAttack { get; set; }
        public string GetProfessionAbilityReadier(int index)
        {
            return ProfessionAbilitiesReadier[index];
        }

        public string GetProfessionAbilityAttack(int index)
        {
            return ProfessionAbilitiesAttack[index];
        }

        public string Label { get; set; }
        public int Option { get; set; }
        public string AskForOptionAndLabel()
        {
            return $"{Option}. {Label}";
        }
    }
}
