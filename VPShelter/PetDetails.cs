using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class PetDetails : VirtualPet
    {
        //Create fields/properties for different Pets
        private string petType;

        public  string PetType
        {
            get { return this.petType; }
            set { this.petType = value; }
        }

        private string petDiet;

        public string PetDiet
        {
            get { return this.petDiet; }
            set { this.petDiet = value; }
        }
        
        //Constructor 
        public PetDetails(string petType, string petDiet, string name, int hunger, int thirst, int waste)
        {
            this.PetType = petType;
            this.PetDiet = petDiet;
            this.Name = name;
            this.Hunger = hunger;
            this.Thirst = thirst;
            this.Waste = waste;
        }

        //private string dog;

        //public string Dog
        //{
        //    get { return this.dog; }
        //    set { this.dog = value; }
        //}
        //private string cat;

        //public string Cat
        //{
        //    get { return this.Cat; }
        //    set { this.cat = value; }
        //}
        //private string snake;

        //public string Snake
        //{
        //    get { return this.Snake; }
        //    set { this.snake = value; }
        //}
        //private string horse;

        //public string Horse
        //{
        //    get { return this.horse; }
        //    set { this.horse = value; }
        //}
        ////Create fields properties for diet
        //private string dogFood;

        //public string DogFood
        //{
        //    get { return this.dogFood; }
        //    set { this.dogFood = value; }
        //}
        //private string catfood;

        //public string Catfood
        //{
        //    get { return this.catfood; }
        //    set { this.catfood = value; }
        //}
        //private string snakeFood;

        //public string SnakeFood
        //{
        //    get { return this.snakeFood; }
        //    set { this.snakeFood = value; }
        //}
        //private string horseFood;

        //public string HorseFood
        //{
        //    get { return this.horseFood; }
        //    set { this.horseFood = value; }
        //}








    }
}
