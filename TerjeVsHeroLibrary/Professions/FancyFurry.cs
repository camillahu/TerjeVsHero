using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp20;
using TerjeVsHeroLibrary.Interfaces;

namespace TerjeVsHeroLibrary.Classes
{
    public class FancyFurry : Profession
    {
        //public string Label => "Fancy Furry";
        //public int Option => 1;
        public FancyFurry(string name = "Fancy Furry")
        {
            Label = "Fancy Furry";
            Option = 1;
            StrengthModifier = 5;
            Energy = 15;
            ProfessionAbilityName 
            = new List<string>
            {
                new("Wolf"),
                new("Snake"),
                new("Turtle")
            };
            ProfessionAbilitiesReadier
            = new List<string>
            {
                new(""),
                new(""),
                new("You approach your enemy with the speed of a turtle, getting ready to attack"),
            };
            ProfessionAbilitiesAttack
            = new List<string>
            {
                new(""),
                new(""),
                new("You clench your strong turtle jaw around your enemies nose"),
            };
        }

        //public string AskForOptionAndLabel()
        //{
        //    return $"{Option}. {Label}";   
        //}
        //public int StrengthModifier => 5;
        //public int Energy => 15;
        
        //public List<string> ProfessionAbilityName { get; }
        //    = new List<string>()
        //    {
        //        new("Wolf"),
        //        new("Snake"),
        //        new("Turtle")
        //    };
        //public List<string> ProfessionAbilitiesReadier { get; }
        //    = new List<string>()
        //    {
        //        new(""),
        //        new(""),
        //        new("You approach your enemy with the speed of a turtle, getting ready to attack"),
        //    };

         //public List<string> ProfessionAbilitiesAttack { get; }
         //   = new List<string>()
         //   {
         //       new(""),
         //       new(""),
         //       new("You clench your strong turtle jaw around your enemies nose"),
         //   };
        //public string GetProfessionAbilityReadier(int index)
        //{
        //    return ProfessionAbilitiesReadier[index];
        //}
        //public string GetProfessionAbilityAttack(int index)
        //{
        //    return ProfessionAbilitiesAttack[index];
        //}


    }
}
