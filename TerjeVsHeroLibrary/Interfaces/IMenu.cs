using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerjeVsHeroLibrary.Interfaces
{
    public interface IMenu
    {
        public List<ICommand> options { get; set; }
        List<string> GetStringList();
    }
}
