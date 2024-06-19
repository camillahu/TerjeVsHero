using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerjeVsHeroLibrary;
using TerjeVsHeroLibrary.Interfaces;
using TerjeVsHeroLibrary.Races;

// Samleklasse for alle stats og metoder som en playable character skal ha
// Denne skal ikke new'es

namespace ConsoleApp20
{
    public abstract class Hero : Game, IProfession/* IRace*/
    {
        public Hero()
        {

        }

        public int Energy { get; set; }
        public int StrengthModifier { get; set; }
        public List<string> ProfessionAbilityName { get; }
        public List<string> ProfessionAbilitiesReadier { get; }
        public List<string> ProfessionAbilitiesAttack { get; }
        public string GetProfessionAbilityReadier(int index)
        {
            throw new NotImplementedException();
        }

        public string GetProfessionAbilityAttack(int index)
        {
            throw new NotImplementedException();
        }

        public Race MyRace { get; set; }
        //public double DexterityModifier { get; set; }
        //public double HPModifier { get; set; }
    }
}
