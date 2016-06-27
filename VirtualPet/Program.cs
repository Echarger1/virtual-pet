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
                Console.WriteLine("ENTER PET NAME:");
                string PetName = Console.ReadLine();

                while (true)
                {

                    Console.WriteLine();
                    Console.WriteLine("TYPE OPTION TWICE");
                    Console.WriteLine("1. FEED YOUR PET BRO");
                    Console.WriteLine("2. WATER YOUR PET");
                    Console.WriteLine("3. SLEEP YOUR PET");
                    Console.WriteLine("4. EXIT YOUR PET");

                    int choice = Convert.ToInt32(Console.ReadLine());
                    if (choice == 1)
                    {
                        UserFood = Convert.ToInt32(Console.ReadLine());
                        Dog.FEED(UserFood);
                        Dog.TICK();
                        Dog.STATUS();
                        Console.WriteLine("{0} has eaten", PetName);
                    }
                    else if (choice == 2)
                    {
                        UserDrink = Convert.ToInt32(Console.ReadLine());
                        Dog.DRINK(UserDrink);
                        Dog.TICK();
                        Dog.STATUS();
                        Console.WriteLine("{0} drank water", PetName);
                    }
                    else if (choice == 3)
                    {
                        UserSleep = Convert.ToInt32(Console.ReadLine());
                        Dog.SLEEP(UserSleep);
                        Dog.TICK();
                        Dog.STATUS();
                        Console.WriteLine("{0} has slept", PetName);
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
