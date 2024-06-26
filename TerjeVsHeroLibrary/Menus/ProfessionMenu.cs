using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerjeVsHeroLibrary.Classes;
using TerjeVsHeroLibrary.Interfaces;
using TerjeVsHeroLibrary.Professions;

namespace TerjeVsHeroLibrary.Menus
{
    public class ProfessionMenu : IMenu<Profession>
    {
        public List<Profession> Options { get; set; } = new List<Profession>()
        {
            new FancyFurry(),
            new BladeBonk(),
        };

        public List<string> GetStringList()
        {
            List<string> output = new List<string>();
            foreach (var item in Options)
            {
                output.Add(item.AskForOptionAndLabel());
            }

            return output;
        }
    }
}
