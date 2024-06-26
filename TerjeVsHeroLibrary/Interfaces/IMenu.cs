using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerjeVsHeroLibrary.Interfaces
{
    public interface IMenu<T>
    {
        public List<T> Options { get; set; } 
        List<string> GetStringList();
    }
}
