using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    public interface IMenu
    {
        List<string> options { get; set; }
        void Show();
    }
}
