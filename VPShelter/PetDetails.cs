using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class PetDetails : VirtualPet
    {
        //Create fields/properties for different Pets
        private string dog;

        public string Dog
        {
            get { return this.dog; }
            set { this.dog = value; }
        }
        private string cat;

        public string Cat
        {
            get { return this.Cat; }
            set { this.cat = value; }
        }
        private string snake;

        public string Snake
        {
            get { return this.Snake; }
            set { this.snake = value; }
        }
        private string horse;

        public string Horse
        {
            get { return this.horse; }
            set { this.horse = value; }
        }
        //Create fields properties for diet
        private string dogFood;

        public string DogFood
        {
            get { return this.dogFood; }
            set { this.dogFood = value; }
        }
        private string catfood;

        public string Catfood
        {
            get { return this.catfood; }
            set { this.catfood = value; }
        }
        private string snakeFood;

        public string SnakeFood
        {
            get { return this.snakeFood; }
            set { this.snakeFood = value; }
        }
        private string horseFood;

        public string HorseFood
        {
            get { return this.horseFood; }
            set { this.horseFood = value; }
        }








    }
}
