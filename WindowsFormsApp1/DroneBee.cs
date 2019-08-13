using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bees
{
    class DroneBee : Bee
    {
        //overrides base class method to create unique death logic
        public override void CheckIfAlive()
        {
            //if health below 50 then declares bee dead
            if (Health < 50f)
            {
                dead = true;
            }
        }
    }
}
