using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerjeVsHeroLibrary;
using TerjeVsHeroLibrary.Interfaces;
using TerjeVsHeroLibrary.Races;

// Samleklasse for alle stats og metoder som en playable character skal ha

namespace ConsoleApp20
{
    public class Hero : Game
    {
       
        public Race MyRace { get; set; }
        public Profession MyProfession { get; set; }
        
   
        public Hero(string name, Race race, Profession profession)
        {
            Name = name;
            MyRace = race;
            MyProfession = profession;
        }
        
    }
}
