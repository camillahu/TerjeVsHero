using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerjeVsHeroLibrary;
using TerjeVsHeroLibrary.Interfaces;
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
            // ask to pick a race for your character
            "What race would you like to play as?".PrintToConsole();
        
            var race = PickRace();
            // ask to pick a class for your character
            "What profession would you like to play as?".PrintToConsole();
            // show profession menu
            ShowProfessionMenu();

            // make a variable takes in the picked class
            var heroClass = PickProfession();
            // create new player object with the variables (eg: new Player(name, race, profession))
        }

        private static void ShowRaceMenu(RaceMenu menu)
        {
            foreach (var item in menu.GetStringList())
            {
                item.PrintToConsole();
            }

        }

        private static void ShowProfessionMenu()
        {
            var menu = new ProfessionMenu();
            foreach (var item in menu.GetStringList())
            {
                item.PrintToConsole();
            }
        }

        private static ICommand PickRace()
        {
            var menu = new RaceMenu();
            ShowRaceMenu(menu);
            var userInput = "Pick a number from the menu above:".RequestInt();
            return menu.options[userInput-1];
        }

        private static int PickProfession()
        {
            return 0;
        }
    }
}
