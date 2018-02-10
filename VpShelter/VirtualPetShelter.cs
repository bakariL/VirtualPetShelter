using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VpShelter
{
    public abstract class VirtualPetShelter
    {

        
        //prop
        public string PetHouse { get; set; }
        public string EmployeeLounge { get; set; }


        //contructors
        public VirtualPetShelter()
        {
            //default
        }

        public VirtualPetShelter(string petHouse, string employeeLounge )
        {
            this.PetHouse = petHouse;
            this.EmployeeLounge = employeeLounge;
        }

        //instansite a list of employee objects 
        Volunteer volunteerOne = new Volunteer();
        List<Volunteer> volunteerList = new List<Volunteer>();
        //managers
        Manager managerOne = new Manager();
        List<Manager> managerList = new List<Manager>();

        //instansite a liste of animal objects
        Pets firstPet = new Pets();
        List<Pets> petsList = new List<Pets>();


    
     
    






























        Pets cat = new Pets {};
        Pets dog = new Pets { };
        Pets lion = new Pets { };
        
        List<Pets> petList = new List<Pets>
        {
            
            new Pets(){ Cat = "Whiskers", CatFood = "Salmon",},
            new Pets(){Dog = "Barki", DogFood="Kibbles & bites" },
            new Pets(){Lion = "Simba", RawMeat = "RawMeat"}   
        };



        //method
        public void SeeAnimalList()
        {
            foreach(object Pets in petList)
            {
                
                Console.WriteLine(Pets);
            }
        }


    }
}
