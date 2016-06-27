using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class PET
    {

        private string petname; private int hunger; private int thirst;
        private int sleep;

        int NewFoodAmnt; int NewDrinkAmnt; int NewTiredAmnt;

        public string PetName {
            get
            {
                return petname;
            }
            set
            {
                petname = value;
            }
        }
        public int Hunger
        {
            get
            {
                return hunger;
            }
            set
            {
                hunger = value;
            }
        }
        public int Thirst
        {
            get
            {
                return thirst;
            }
            set
            {
                thirst = value;
            }
        }
        public int Sleep
        {
            get
            {
                return sleep;
            }
            set
            {
                sleep = value;
            }
        }

        public PET()
        {

        }

        public PET(int HungerAmnt, int DrinkAmnt, int TiredAmnt)
        {
            hunger = HungerAmnt; thirst = DrinkAmnt; sleep = TiredAmnt;
        }

        public void TICK()
        {
            hunger += NewFoodAmnt;
            thirst += NewDrinkAmnt;
            sleep += NewTiredAmnt;
        }

        public void STATUS()
        {
            Console.WriteLine("Status: {1} {2} {3}", PetName, hunger, thirst, sleep);
        }

        public void FEED(int Food)
        {
            NewFoodAmnt = Food;


        }

        public void DRINK(int Water)
        {
            NewDrinkAmnt = Water;
            
        }

        public void SLEEP(int Tired)
        {
            NewTiredAmnt = Tired;
            
        }
    }
}