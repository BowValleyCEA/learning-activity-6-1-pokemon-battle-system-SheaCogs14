using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Will be the child class for normal pokemon will inherit info from parent class
namespace game1401_la_starter
{
    internal class Normal : Pokemon
    {

        public Normal(string aCurrentName, int aCurrentHealth, int aMaxhealh, int aBaseDamage) : base(aCurrentName, aCurrentHealth)
        {
        }

        internal override void ReciveAttack(Pokemon target)
        {
            int damage = baseDamage;

            if (target is Normal)
            {
                damage *= 2;

            }

            target.currentHealth -= damage;


            Console.WriteLine($"{target.Name} has taken {damage} damage!");
        }
    }
}
