using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Local Variables
            string exitMainMenu = "no";
            int userResponse;
            string exitExistingMenu = "no";

            //While loop for main menu
            Console.WriteLine("Welcome to the Seamus Hobans Pet Shop");
            while (exitMainMenu.Equals("no"))
            {
                Console.WriteLine("Are you a manager or an volunteer?");
                Console.WriteLine("Select 1 if your a manager");
                Console.WriteLine("Select 2 if your an volunteer");
                Console.WriteLine("Select 3 to exit");
                userResponse = int.Parse(Console.ReadLine());
                Console.Clear();
                exitExistingMenu = "no";

                if (userResponse == 1)
                {
                    Console.WriteLine("Thank you for being a great manager, do you want to:");
                    Console.WriteLine("Select 1 to feed the pets.");
                    Console.WriteLine("Select 2 to play with the pets.");
                    Console.WriteLine("Select 3 to pay the bills.");
                    userResponse = int.Parse(Console.ReadLine());
                    Console.Clear();

                }
                else if (userResponse == 2)
                {
                    Console.WriteLine("Thank you for being a most needed volunteer, do you want to:");
                    Console.WriteLine("Select 1 to feed the pets.");
                    Console.WriteLine("Select 2 to play with the pets.");
                    Console.WriteLine("Select 3 to give water to the pets.");
                    userResponse = int.Parse(Console.ReadLine());
                    Console.Clear();
                }
                else if (userResponse == 3)
                {
                    Console.WriteLine("Thank you for coming to Seamus Hobans Pet Shop.");
                    exitMainMenu = "yes";
                    Console.Clear();
                }
                else 
                {
                    Console.WriteLine("Please select a valid respone.");
                }

                

                    

                
            }

        }
    }
}
