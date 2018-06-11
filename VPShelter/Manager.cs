using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class Manager : Employee
    {
        int petChoice;
        //properties/fields
        public PetDetails Dog { get; set; }
        public PetDetails Cat { get; set; }
        public PetDetails Bird { get; set; }
        public PetDetails Turtle { get; set; }
        

        public override void Play()
        {
            Console.WriteLine("Which pet would you like to play with?");
            Console.WriteLine("For" + Dog.PetType + Dog.Name + "press 1");
            Console.WriteLine("For" + Cat.PetType + Cat.Name + "press 2");
            Console.WriteLine("For" + Bird.PetType + Bird.Name + "press 3");
            Console.WriteLine("For" + Turtle.PetType + Turtle.Name + "press 4");
            petChoice = int.Parse(Console.ReadLine());

            switch (petChoice)
            {
                case 1:
                    Console.WriteLine("You're playing with the dog");
                    break;
                case 2:
                    Console.WriteLine("You're playing with the cat");
                    break;
                case 3:
                    Console.WriteLine("You're playing with bird");
                    break;
                case 4:
                    Console.WriteLine("You're playing with the turtle");
                    break;
            }
        }

        public override void ViewStatus()
        {
            Console.WriteLine("animal:" + Dog.PetType + "name:" + Dog.Name + "thirst:" + Dog.Thirst + "hunger:" + Dog.Hunger + "waste:" + Dog.Waste);
            Console.WriteLine("animal:" + Cat.PetType + "name:" + Cat.Name + "thirst:" + Cat.Thirst + "hunger:" + Cat.Hunger + "waste:" + Cat.Waste);
            Console.WriteLine("animal:" + Bird.PetType + "name:" + Bird.Name + "thirst:" + Bird.Thirst + "hunger:" + Bird.Hunger + "waste:" + Bird.Waste);
            Console.WriteLine("animal:" + Turtle.PetType + "name:" + Turtle.Name + "thirst:" + Turtle.Thirst + "hunger:" + Turtle.Hunger + "waste:" + Turtle.Waste);

        }



        public Manager()
        {
            //Default Constructor
        }

        public Manager(int respectLevel, bool paidTheBills)
        {
            //Loaded Constructor
            this.RespectLevel = respectLevel;
            this.PaidTheBills = paidTheBills;
        }

        //Overide Method from Employee Class
        public override void Feed()
        {
            allPetsHungerLevel--;
        }

        //public override void Play()
        //{
        //    allPetsPlayLevel--;
        //}

        //public override void ViewStatus()
        //{
        //    allPetsViewStatus++;
        //}

        //Additional property
        private int respectLevel;

        public int RespectLevel
        {
            get { return this.respectLevel; }
            set { this.respectLevel = value; }
        }

        //Method for adopting a pet
        public void AdoptAPet()
        {
            Console.WriteLine("Which pet would you like to adopt?");
            Console.WriteLine("For" + Dog.PetType + Dog.Name + "press 1");
            Console.WriteLine("For" + Cat.PetType + Cat.Name + "press 2");
            Console.WriteLine("For" + Bird.PetType + Bird.Name + "press 3");
            Console.WriteLine("For" + Turtle.PetType + Turtle.Name + "press 4");
            petChoice = int.Parse(Console.ReadLine());

            switch (petChoice)
            {
                case 1:
                    Console.WriteLine("You're adopting the dog" + Dog.Name);
                    break;
                case 2:
                    Console.WriteLine("You're adopting the cat" + Cat.Name);
                    break;
                case 3:
                    Console.WriteLine("You're adopting the bird" + Bird.Name);
                    break;
                case 4:
                    Console.WriteLine("You're adopting the turtle" + Turtle.Name);
                    break;
            }
        }



        public bool PayBills()
        {
            respectLevel++;
            return paidTheBills = true;
        }

        private bool paidTheBills;

        public bool PaidTheBills
        {
            get { return paidTheBills; }
            set { paidTheBills = value; }
        }
        




    }
}
