using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerjeVsHeroLibrary.Interfaces;

namespace ConsoleApp20
{
    public class Hero : Game, IProfession, IRace
    {
        public Hero(string name) : base(name)
        {

        }

        public int Energy { get; set; }
        public int StrengthModifier { get; set; }
        public double DexterityModifier { get; set; }
        public double HPModifier { get; set; }
    }
}
