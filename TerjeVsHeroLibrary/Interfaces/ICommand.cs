using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerjeVsHeroLibrary.Interfaces
{
    public interface ICommand
    {
        public string Label { get; }
        public int Option { get; }

        public string AskForOptionAndLabel();
    }
}
