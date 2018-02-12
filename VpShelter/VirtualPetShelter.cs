using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VpShelter
{
    public class VirtualPetShelter
    {
        //instansite a list of employee objects 
        
    

        //prop
        public string PetHouse { get; set; }
        public string EmployeeLounge { get; set; }
        public List<Pets> PetList { get; set; }


        //contructors
        public VirtualPetShelter()
        {
            //default
        }

        public VirtualPetShelter(string petHouse, string employeeLounge, List<Pets> petList)
        {
            this.PetHouse = petHouse;
            this.EmployeeLounge = employeeLounge;
            this.PetList = petList;
           
        }

        public VirtualPetShelter(List<Pets> petList, string dog, string cat, string Lion)
        {
            this.PetList = petList;
            this.PetList = PetList;
            

        }


        Volunteer volunteerOne = new Volunteer();
        List<Volunteer> volunteerList = new List<Volunteer>();
        //managers
        Manager managerOne = new Manager();
        List<Manager> managerList = new List<Manager>();
      //  instansite a liste of animal objects

        //method
        public void SeeAnimalList()
        {

            return ;
        }
        


    }
}
