using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Volunteer : Employee
    {
        //Overide method from Employee Class
        public override void Feed()
        {
            allPetsHungerLevel--;
        }

        public override void Play()
        {
            allPetsPlayLevel--;
        }

        public override void ViewStatus()
        {
            allPetsViewStatus++;
        }

        //Additional property
        private int satisfaction;

        public int Satisfaction
        {
            get { return this.satisfaction; }
            set { this.satisfaction = value; }
        }

        //Method for feeding all pets
        //public Feed();

        //Method for watering all pets
        public void Water()
        {
            allPetsThirstLevel--;
        }



    }
}
