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
        private int play; private int sleep;

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
        public int Play
        {
            get
            {
                return play;
            }
            set
            {
                play = value;
            }
        }
        public int Sleep
        {
            get
            {
                return play;
            }
            set
            {
                sleep = value;
            }
        }


        public PET()
        {


        }



        public static void FEED()
        {
            
        }

        public static void DRINK()
        {
            
        }

        public static void SLEEP()
        {
            
        }
    }
}
