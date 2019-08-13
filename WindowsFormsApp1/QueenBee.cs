using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bees
{
    class QueenBee: Bee
    {
        //overrides base class method to create unique death logic
        public override void CheckIfAlive()
        {
            //if health below 20 then declares bee dead
            if (Health < 20f)
            {
                dead = true;
            }
        }
    }
}
