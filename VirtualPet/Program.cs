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
                    
                    Console.WriteLine("╔══╗───╔═╗──────");
                    Console.WriteLine("║║║╠╦╗─║╚╠═╦═╦═╗");
                    Console.WriteLine("║║║║╔╬╗║╔║╩╣╬║║║");
                    Console.WriteLine("╚╩╩╩╝╚╝╚═╩═╩╩╩╩╝");
                    Console.WriteLine("________________1¶¶¶¶¶¶¶¶¶¶¶1________________");
                    Console.WriteLine("_____________¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶1____________");
                    Console.WriteLine("__________¶¶¶¶118¶¶8¶¶¶¶¶¶¶¶¶¶¶¶¶¶___________");
                    Console.WriteLine("_______8¶¶¶¶888¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶8________");
                    Console.WriteLine("______¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶______");
                    Console.WriteLine("____8¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶____");
                    Console.WriteLine("___¶¶¶¶¶¶¶¶¶¶¶8¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶8¶¶¶___");
                    Console.WriteLine("__8¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶8¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶8¶¶¶¶__");
                    Console.WriteLine("__¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶88881__¶¶¶¶¶¶¶__");
                    Console.WriteLine("_¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶81___________¶¶¶¶¶¶__");
                    Console.WriteLine("1¶¶¶¶¶111____________________________8¶¶¶¶¶¶_");
                    Console.WriteLine("¶¶¶¶¶1___________________________1___1¶¶¶¶¶¶_");
                    Console.WriteLine("¶¶¶¶¶8111___________________________11¶¶¶¶¶¶_");
                    Console.WriteLine("1¶¶¶¶88111__________________________111¶¶¶¶¶_");
                    Console.WriteLine("_¶¶¶¶1881________________________11111_¶¶¶¶¶_");
                    Console.WriteLine("_¶¶¶¶18811_____________________¶¶¶¶¶¶8_1¶¶¶¶1");
                    Console.WriteLine("_¶¶¶¶118¶¶¶¶81______________8¶¶¶¶¶¶¶¶¶_1¶¶¶8¶");
                    Console.WriteLine("_8¶¶881¶¶¶¶¶¶¶¶¶1_________1¶¶¶¶811__1¶811¶¶1¶");
                    Console.WriteLine("¶¶¶¶118¶1__18¶¶¶¶¶8118818¶¶¶88¶111¶888¶11¶¶18");
                    Console.WriteLine("¶8¶¶11¶¶11¶¶111¶¶¶¶¶1___1¶¶¶¶1_1¶__¶¶8888¶¶8_");
                    Console.WriteLine("_1¶¶11¶¶¶¶¶_8¶8_8¶8¶¶____8188__¶¶__¶1__18881_");
                    Console.WriteLine("__8¶88111¶¶_8¶8__1__11___1___111_181___18811_");
                    Console.WriteLine("__11881___181111____11_________________1881__");
                    Console.WriteLine("__118¶81_____________8_________________1881__");
                    Console.WriteLine("___18¶¶1__________1111_____1_11______1_188___");
                    Console.WriteLine("___88¶¶8________88____________8¶81____188____");
                    Console.WriteLine("______1¶1_____8¶888_11____18¶¶118¶8888888____");
                    Console.WriteLine("_______¶¶8881¶¶818¶¶¶¶¶8_1¶¶¶8118¶¶¶¶8888____");
                    Console.WriteLine("_______¶¶¶¶¶¶¶¶881188¶¶¶¶¶¶818¶¶¶¶¶__1888____");
                    Console.WriteLine("_______¶888¶18¶¶¶¶¶8888¶¶¶8¶¶¶¶8_11__88¶_____");
                    Console.WriteLine("______1¶¶8181_118¶¶¶¶¶¶¶¶¶¶¶¶8111___8¶¶______");
                    Console.WriteLine("¶¶¶¶¶¶¶¶¶¶88¶8_1_18¶¶¶¶¶¶¶8881_____1¶8_______");
                    Console.WriteLine("88888¶¶¶¶¶¶¶¶¶8_11118881111_______8¶¶________");
                    Console.WriteLine("88118¶__¶¶8¶8888_1_____________18¶¶_¶¶_______");
                    Console.WriteLine("88888¶___¶¶8818¶¶11_1_______11¶¶¶8__¶¶¶______");
                    Console.WriteLine("¶81¶¶¶____1¶¶¶88¶¶¶88888188¶¶¶¶81__¶¶¶¶¶_____");
                    Console.WriteLine("88¶¶¶8______¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶811__1¶¶¶¶¶¶1____");
                    Console.WriteLine("8¶¶8_________11_1¶¶¶¶¶¶¶888811__¶¶¶¶8¶¶¶¶1___");
                    Console.WriteLine("¶¶8_______¶¶¶¶¶_____11118881__1¶¶¶¶¶¶¶¶¶¶¶___");
                    Console.WriteLine("¶1_______¶¶¶¶¶¶______________¶¶¶¶¶¶¶¶¶8¶¶¶8__");
                    Console.WriteLine("¶_______¶¶¶¶¶¶¶____________1¶¶¶¶¶¶¶8¶¶¶88¶¶8_");
                    Console.WriteLine("_______1¶¶¶¶8_____________¶¶¶¶¶8¶¶¶888888¶¶¶8");
                    Console.WriteLine("_______¶¶¶¶_____________1¶¶¶¶¶88¶¶¶¶¶88¶¶¶88¶");
                    Console.WriteLine("______¶¶¶¶¶____________¶¶¶¶8888¶8¶88881¶8¶888");
                    Console.WriteLine("_____¶¶¶¶¶8__________8¶¶88¶18818¶88118¶88888¶");
                    

                    Console.WriteLine();
                    Console.WriteLine("TYPE OPTION TWICE");
                    Console.WriteLine("1. FEED YOUR PET");
                    Console.WriteLine("2. WATER YOUR PET");
                    Console.WriteLine("3. SLEEP YOUR PET");
                    Console.WriteLine("4. EXIT YOUR PET");

                    int choice = Convert.ToInt32(Console.ReadLine());
                    if (choice == 1)
                    {
                        UserFood = choice;
                        Dog.FEED(UserFood);
                        Dog.TICK();
                        Dog.STATUS();
                        Console.WriteLine("{0} has eaten", PetName);
                    }
                    else if (choice == 2)
                    {
                        UserDrink = choice;
                        Dog.DRINK(UserDrink);
                        Dog.TICK();
                        Dog.STATUS();
                        Console.WriteLine("{0} drank water", PetName);
                    }
                    else if (choice == 3)
                    {
                        UserSleep = choice;
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
