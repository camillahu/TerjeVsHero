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
            // ask to pick a race for your character
            "What race would you like to play as?".PrintToConsole();
            ShowRaceMenu();
            // make a variabel that takes in the answer of the question, what race

            // ask to pick a class for your character
            
            // show class menu
            "What class would you like to play as?".PrintToConsole();
            ShowClassMenu();

            // make a variable takes in the picked class
            var class = PickClass();
            // create hero object using the variables  



        }

        private static void ShowRaceMenu()
        {
            var menu = new RaceMenu();
            foreach (var item in menu.GetStringList())
            {
                item.PrintToConsole();
            }
        
        }

        private static void ShowClassMenu()
        {
            var menu = new ClassMenu();
            foreach(var item in menu.GetStringList())
            {
                item.PrintToConsole();
            }
        }

        private static int PickRace()
        {

        }
