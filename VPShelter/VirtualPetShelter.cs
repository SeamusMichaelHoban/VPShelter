using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class VirtualPetShelter
    {

        //fileds and properties for storing all pets and employees
        private int numEmployees;

        public int NumEmployees
        {
            get { return this.numEmployees; }
            set { this.numEmployees = value; }
        }

        private int numPets;

        public int NumPets
        {
            get { return this.numPets; }
            set { this.numPets = value; }
        }
        //Creating lists
        List<PetDetails> petNames = new List<PetDetails>();
        List<Employee> employeeNames = new List<Employee>();



    }
}
