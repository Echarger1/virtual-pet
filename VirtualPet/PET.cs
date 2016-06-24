using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class PET
    {
        public string PetName { get; set; }
        public int Hunger { get; set; }
        public int Thirst { get; set; }
        public int Play { get; set; }
        public int Sleep { get; set; }

        public void MainMenu()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("1. FEED YOUR PET BRO");
                Console.WriteLine("2. WATER YOUR PET");
                Console.WriteLine("3. PLAY YOUR PET");
                Console.WriteLine("4. EXIT YOUR PET");

                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {

                }
                else if (choice == 2)
                {

                }
                else if (choice == 3)
                {

                }
                else if (choice == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("NOT A VALID NUMBER TRY AGAIN");
                }
            }
        }
        
    }
}
