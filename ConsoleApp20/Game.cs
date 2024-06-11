using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    public abstract class Game : IGameActions
    {
        public string Name { get; protected set; }
        public double HP { get; protected set; }

        public double Strength { get; protected set; }

        public double Dexterity { get; protected set; }

        public bool IsAlive { get; protected set; } = true;

        public virtual double BasicAttack()
        {
            return Strength/2;
        }

        protected Game(string name, double hp, double strength, double dexterity)
        {
            Name = name;
            HP = hp;
            Strength = strength;
            Dexterity = dexterity;
        }

        protected Game()
        {

        }
    }
}
