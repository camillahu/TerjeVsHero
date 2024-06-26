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
            Hero player = CharaterCreation();
            //Console.WriteLine($"You just created a hero called {player.Name}, and you're a {player.MyProfession.Label} {player.MyRace.Label}");

        }

        private static Hero CharaterCreation()
        {
            var name = "What is your name Hero: ".RequestString();
            "What race would you like to play as?".PrintToConsole();
            var race = PickRace();

            "What profession would you like to play as?".PrintToConsole();
            var profession = PickProfession();

            Hero hero = new Hero(name, race, profession);
            return hero;
        }

        private static void ShowRaceMenu(RaceMenu menu)
        {
            foreach (var item in menu.GetStringList())
            {
                item.PrintToConsole();
            }

        }

        private static void ShowProfessionMenu(ProfessionMenu menu)
        {
            foreach (var item in menu.GetStringList())
            {
                item.PrintToConsole();
            }
        }

        private static Race PickRace()
        {
            var menu = new RaceMenu();
            ShowRaceMenu(menu);
            var userInput = "Pick a number from the menu above:".RequestInt();
            return menu.Options[userInput-1];
        }

        private static Profession PickProfession()
        {
            var menu = new ProfessionMenu();
            ShowProfessionMenu(menu);
            var userInput = "Pick a number from the menu above:".RequestInt();
            return menu.Options[userInput - 1];
        }
    }
}
