using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VpShelter
{
    public class VirtualPetShelter
    {
        private string listofPets;


        //prop
        public string PetHouse { get; set; }
        public string EmployeeLounge { get; set; }
        public List<Pets> ListofPets { get; set; }


        //contructors
        public VirtualPetShelter()
        {
            //default
        }

        public VirtualPetShelter(string petHouse, string employeeLounge)
        {
            this.PetHouse = petHouse;
            this.EmployeeLounge = employeeLounge;
            //instansite a list of employee objects 
            Volunteer volunteerOne = new Volunteer();
            List<Volunteer> volunteerList = new List<Volunteer>();
            //managers
            Manager managerOne = new Manager();
            List<Manager> managerList = new List<Manager>();

            //instansite a liste of animal objects
            Pets firstPet = new Pets();
            List<Pets> petsList = new List<Pets>() {
            new Pets() { Name = "Barki" }
            };
        }

        public VirtualPetShelter(List<Pets> listofPets)
        {
            this.ListofPets = listofPets;
        }

        public VirtualPetShelter(string listofPets)
        {
            this.listofPets = listofPets;
        }

        //method
        public void SeeAnimalList<Pets>(List<Pets> petsList)
        {


            Console.WriteLine(petsList);
        }


    }
}
