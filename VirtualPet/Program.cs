using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program

    {
        static void Main(string[] args)
        {
            PET Dog = new PET();
            int UserFood; int UserDrink; int UserSleep;
            Console.WriteLine("WELCOME TO CREATE A PET");

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
                        UserFood = Convert.ToInt32(Console.ReadLine());
                        Dog.FEED(UserFood);
                        Dog.TICK();
                    }
                    else if (choice == 2)
                    {
                        UserDrink = Convert.ToInt32(Console.ReadLine());
                        Dog.DRINK(UserDrink);
                        Dog.TICK();
                    }
                    else if (choice == 3)
                    {
                        UserSleep = Convert.ToInt32(Console.ReadLine());
                        Dog.SLEEP(UserSleep);
                        Dog.TICK();
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

}
