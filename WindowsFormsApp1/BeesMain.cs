using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bees
{
    class BeesMain
    {
        //variable for random number generation
        Random rnd = new Random();

        //variable array to hold text boxes for each bee
        public List<TextBox> textboxList = new List<TextBox>();

        //variable list to hold the bee objects
        public List<Bee> bees = new List<Bee>();

        // Start is called before the first frame update
        public void Start()
        {
            //loop 10 times to instantiate 10 of each type of bee and add to the list
            for (int i = 0; i < 10; i++)
            {
                bees.Add(new QueenBee());
                bees.Add(new WorkerBee());
                bees.Add(new DroneBee());
            }
        }

        //method loops through all text boxes and updates health and alive status
        public void UpdateBeeText()
        {
            for (int i = 0; i < textboxList.Count; i++)
            {
                string alive = "";

                if (bees[i].dead)
                {
                    alive = "Dead";
                }
                else
                {
                    alive = "Alive";
                }

                textboxList[i].Text = "Health = " + bees[i].Health + " " + alive;
            }
        }

        //method damages all bees by a random percentage of their current health
        public void DamageAllBees()
        {
            for (int i = 0; i < bees.Count; i++)
            {
                int damage = rnd.Next(0, 81); //min value inclusive, max value exclusive
                bees[i].Damage(damage);
            }
        }

        //loops through all bees in the bees list and check their health
        public void CheckAllBeesAlive()
        {
            for (int i = 0; i < bees.Count; i++)
            {
                bees[i].CheckIfAlive();
            }
        }

        //method detects button click and calles DamageAllBees method
        public void ButtonClicked()
        {
            DamageAllBees();
            CheckAllBeesAlive();
            UpdateBeeText();
        }



    }
}
