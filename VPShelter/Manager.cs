using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Manager : Employee
    {
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

        public override void Play()
        {
            allPetsPlayLevel--;
        }

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
