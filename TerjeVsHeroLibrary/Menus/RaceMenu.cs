using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerjeVsHeroLibrary.Interfaces;
using TerjeVsHeroLibrary.Races;

namespace TerjeVsHeroLibrary.Menus
{
    public class RaceMenu : IMenu
    {
        public List<ICommand> options { get; set; } = new List<ICommand>()
        {
           new Fairy(),
        };

        public List<string> GetStringList()
        {
            List<string> output = new List<string>();
            foreach (var item in options)
            {
                output.Add(item.AskForOptionAndLabel());
            }

            return output;
        }
    }
}
