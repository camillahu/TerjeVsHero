using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class EvilGiraffe : Game, INonBossActions
    {
        public EvilGiraffe(string name, double hp, double strength, double dexterity) : base(name, hp, strength, dexterity)
        {
            
        }

        public EvilGiraffe() 
        {
            Name = "Evil Giraffe";
            HP = 30;
            Strength = 5.0;
            Dexterity = 10;
        }

        public NotImplementedException BoostedAttack()
        {
            return new NotImplementedException();
        }
    }
}
