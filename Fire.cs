using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game1401_la_starter
{
    internal class Fire : Pokemon
    {

        public Fire(string aCurrentName, int aCurrentHealth, int aMaxhealh, int aBaseDamage) : base(aCurrentName, aCurrentHealth)
        {
        }


        internal override void ReciveAttack(Pokemon target)
        {
            int damage = baseDamage;

            if (target is Grass)
            {
                damage *= 2;

            }

            target.currentHealth -= damage;


            Console.WriteLine($"{target.Name} has taken {damage} damage!");
        }
    }
}
