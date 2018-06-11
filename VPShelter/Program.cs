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

            //instantiate objects from PetDetails
            PetDetails dog = new PetDetails("Dog", "Dog Food", "Nuno", 25, 5, 7);
            PetDetails cat = new PetDetails("Cat", "Cat Food", "Lucy", 22, 4, 9);
            PetDetails bird = new PetDetails("Bird", "Bird Food", "Tweety", 20, 3, 6);
            PetDetails turtle = new PetDetails("Turtle", "Turtle Food", "Maverick", 24, 6, 5);

            Manager Manager1 = new Manager(0, true);
            Volunteer Volunteer1 = new Volunteer();

            Manager1.Dog = dog;
            Manager1.Cat = cat;
            Manager1.Bird = bird;
            Manager1.Turtle = turtle;

            Volunteer1.Dog = dog;
            Volunteer1.Cat = cat;
            Volunteer1.Bird = bird;
            Volunteer1.Turtle = turtle;


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
                    Manager manager = new Manager(5, false);
                    Console.WriteLine("Thank you for being a great manager, do you want to:");
                    Console.WriteLine("Select 1 to feed the pets.");
                    Console.WriteLine("Select 2 to play with the pets.");
                    Console.WriteLine("Select 3 to pay the bills.");
                    Console.WriteLine("Select 4 to view status of the pet.");
                    Console.WriteLine("Select 5 to adaopt a pet.");
                    userResponse = int.Parse(Console.ReadLine());
                    Console.Clear();

                    //Creating Logic switch statment for manager doin thier 4 tasks
                    switch (userResponse)
                    {
                        case 1:
                                manager.Feed();
                            break;
                        case 2:
                                Manager1.Play();
                            break;
                        case 3:
                                manager.PayBills();
                            break;
                        case 4:
                            Manager1.ViewStatus();
                            break;
                                case 5:
                            Manager1.AdoptAPet();
                            break;
                        default:
                            Console.WriteLine("Thanks you for managing Semus Hobans Pet Store");
                            break;
                    }
                    

                }
                else if (userResponse == 2)
                { 
                    Volunteer volunteer = new Volunteer();
                    Console.WriteLine("Thank you for being a most needed volunteer, do you want to:");
                    Console.WriteLine("Select 1 to feed the pets.");
                    Console.WriteLine("Select 2 to play with the pets.");
                    Console.WriteLine("Select 3 to give water to the pets.");
                    Console.WriteLine("Select 4 to view status of the pets.");
                    userResponse = int.Parse(Console.ReadLine());
                    Console.Clear();

                //Creating logic for volunteer to do thier 3 tasks
                switch (userResponse)
                {
                    case 1:
                            volunteer.Feed();
                        break;
                    case 2:
                            Volunteer1.Play();
                        break;
                    case 3:
                            volunteer.Water();
                        break;
                        case 4:
                            Volunteer1.ViewStatus();
                            break;
                        default:
                            Console.WriteLine("Thankyou for volunteering at Seamus Hobans Pet Shop");
                        break;
                }
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
