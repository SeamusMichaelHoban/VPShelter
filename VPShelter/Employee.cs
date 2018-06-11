using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public abstract class Employee
    {
        //field/prop for employee class
        public int allPetsHungerLevel;
        public int allPetsPlayLevel;
        public int allPetsViewStatus;
        public int allPetsThirstLevel;
        private int employeeID;

        public int EmployeeID
        {
            get { return this.employeeID; }
            set { this.employeeID = value; }
        }

        //Create 2 abstract methods
        public abstract void Feed();

        public abstract void ViewStatus();
        public abstract void Play();
        

        
        







    }
}
