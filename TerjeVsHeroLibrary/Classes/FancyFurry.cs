using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerjeVsHeroLibrary.Interfaces;

namespace TerjeVsHeroLibrary.Classes
{
    internal class FancyFurry : Class, ICommand 
    {
        public string Label { get; }
        public int Option { get; }
        public string AskForOptionAndLabel()
        {
            throw new NotImplementedException();
        }
    }
}
