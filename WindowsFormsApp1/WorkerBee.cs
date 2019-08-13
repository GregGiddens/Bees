using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bees
{
    class WorkerBee: Bee
    {
        //overrides base class method to create unique death logic
        public override void CheckIfAlive()
        {
            //if health below 70 then declares bee dead
            if (Health < 70f)
            {
                dead = true;
            }
        }
    }
}
