using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerjeVsHeroLibrary.Menus;

namespace ConsoleApp20
{
    public static class App
    {
        public static void Run()
        {
            CharaterCreation();
            
        }

        private static void CharaterCreation()
        {
            var name = "What is your name Hero: ".RequestString();
            ShowRaceMenu();
        }

        private static void ShowRaceMenu()
        {
            var menu = new RaceMenu();
            foreach (var item in menu.GetStringList())
            {
                item.PrintToConsole();
            }
        }

        private static int PickRace()
        {

        }
    }
}
