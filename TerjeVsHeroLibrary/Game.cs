using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerjeVsHeroLibrary.Interfaces;

// Grunnbase for alle characters (hero, enemies, boss)

namespace ConsoleApp20
{
    public abstract class Game : IGameActions
    {
        public string Name { get; protected set; }
        public double HP { get; protected set; }

        public double Strength { get; protected set; }

        public double Dexterity { get; protected set; }
        // skal vi ha Energy? Nei

        public bool IsAlive { get; protected set; } = true;

        public virtual double BasicAttack()
        {
            return Strength/2;
        }

        protected Game()
        {
            Name = "";
            Strength = 10;
        }

    }
}
