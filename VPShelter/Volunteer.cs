using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class Volunteer : Employee
    {
        int petChoice;
        //Overide method from Employee Class
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

        public PetDetails Dog{ get; set; }
        public  PetDetails Cat{ get; set; }
        public PetDetails Bird { get; set; }
        public  PetDetails Turtle{ get; set; }


        public override void ViewStatus()
        {
            Console.WriteLine("animal:" + Dog.PetType + "name:" + Dog.Name + "thirst:" + Dog.Thirst + "hunger:" + Dog.Hunger + "waste:" + Dog.Waste);
            Console.WriteLine("animal:" + Cat.PetType + "name:" + Cat.Name + "thirst:" + Cat.Thirst + "hunger:" + Cat.Hunger + "waste:" + Cat.Waste);
            Console.WriteLine("animal:" + Bird.PetType + "name:" + Bird.Name + "thirst:" + Bird.Thirst + "hunger:" + Bird.Hunger + "waste:" + Bird.Waste);
            Console.WriteLine("animal:" + Turtle.PetType + "name:" + Turtle.Name + "thirst:" + Turtle.Thirst + "hunger:" + Turtle.Hunger + "waste:" + Turtle.Waste);

        }

        //Additional property
        private int satisfaction;

        public int Satisfaction
        {
            get { return this.satisfaction; }
            set { this.satisfaction = value; }
        }

        //Method for feeding all pets
        public override void Feed()
        {
            Console.WriteLine("All pets are fed");
        }

        
        //Method for watering all pets
        public void Water()
        {
            Console.WriteLine("All pets are watered");
        }



    }
}
