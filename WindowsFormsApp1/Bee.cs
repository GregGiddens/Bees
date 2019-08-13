using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bees
{
    abstract class Bee
    {
        //variable for bee health, getter for obtaining health value
        private float health = 100;
        public float Health
        {
            get => health;

        }

        //variable for whether bee is alive or not
        public bool dead = false;

        //method reduces bee health by damage parameter as a percentage of the current health
        public void Damage(int damage)
        {
            float sum = damage / 100f;
            health = health - (health * sum);
        }

        public abstract void CheckIfAlive();

    }
}
