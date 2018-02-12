using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VpShelter
{
    class Program
    {

        static void Main(string[] args)
        {
            //Pets firstPet = new Pets();
            //{
            //    List<Pets> petList = new List<Pets>() {

            // new Pets()
            // {  Dog = "Bill the BullDog" , DogFood = "Kibbles & Bites", Hungar = 50, Thirst = 45, IsBord = true },
            // new Pets()
            // {
            //     Cat = "Garfieild",  CatFood = "Meow Mix", Hungar = 25, Thirst = 60, IsBord = true },

            // new Pets()
            // {
            //     Lion = "Simba", RawMeat = "Live Animals", Hungar = 75, Thirst = 50, IsBord = true
            // }
            //};


            //    foreach (Object Pets in petList)
            //    {

            //        Console.WriteLine(Pets);
            //    }

            //List<Pets> petsList = new List<Pets>() {
            //new Pets() { Name = "Barki" }
            //};



            VirtualPetShelter animalHouse = new VirtualPetShelter();
            Pets petOne = new Pets();
            Manager manager = new Manager();


            int userInput;
            int managerInput;
            int volunteerInput;
            string petType;
            string petFeed;
            string petPlay;


            Console.WriteLine("Welcome to the Lewis animal house. What employee type are you?");
            Console.WriteLine("1. Manager");
            Console.WriteLine("2. Volunteer");
            userInput = int.Parse(Console.ReadLine());



            if (userInput == 1)
            {
                Console.Clear();
                Console.WriteLine("Thank you for working at Lewis' animal house");
                Console.WriteLine("\n");
                Console.WriteLine("what would you like to do?");
                Console.WriteLine("1. Adopt a pet");
                Console.WriteLine("2. Feed the pets");
                Console.WriteLine("3. Play with the pet");
                Console.WriteLine("4. Pay the bills");
                Console.WriteLine("5. quit");
                managerInput = int.Parse(Console.ReadLine());
                Console.Clear();
                if (managerInput == 1)
                {
                    Console.Clear();
                    petOne.SeePetInfo();
                    Console.WriteLine("What type of pet would you like to adopt: Dog, Cat, Lion?");//type of pet
                    petType = Console.ReadLine().ToUpper();
                    if (petType == "DOG")
                    {

                        //method for adopt pet goes here
                        Console.Clear();
                        petOne.DogAdopted();
                        Console.WriteLine("Push enter..");
                        Console.ReadLine();
                        Start();



                    }
                    else if (petType == "CAT")
                    {
                        //method for apodting cat
                        Console.Clear();
                        petOne.CatAdopted();
                        Console.WriteLine("Push enter to keep playing");
                        Console.ReadLine();
                        Start();

                    }
                    else if (petType == "LION")
                    {
                        //method for apoting Lion goes here 
                        Console.Clear();
                        petOne.LionAdopted();
                        Console.WriteLine("Push enter to keep playing");
                        Console.ReadLine();
                        Start();

                    }
                }

                else if (managerInput == 2)
                {
                    Console.WriteLine("Which animal would you like to feed: Dog, Cat, Lion? ");
                    petFeed = Console.ReadLine().ToUpper();
                    if (petFeed == "DOG")
                    {
                        //method for feeding pets
                        Console.Clear();
                        manager.Feed();
                        petOne.Eating();
                        Console.WriteLine("\n");
                        petOne.SeePetInfo();
                        Console.WriteLine("Push enter to keep playing");
                        Console.ReadLine();
                        Start();

                    }
                    else if (petFeed == "CAT")
                    {
                        //method for feeding pets
                        Console.Clear();
                        manager.Feed();
                        petOne.Eating();
                        Console.WriteLine("\n");
                        petOne.SeePetInfo();
                        Console.WriteLine("Push enter to keep playing");
                        Console.ReadLine();
                        Start();
                    }

                    else if (petFeed == "LION")
                    {
                        //method for feeding pets
                        Console.Clear();
                        manager.Feed();
                        petOne.Eating();
                        Console.WriteLine("\n");
                        petOne.SeePetInfo();
                        Console.WriteLine("Push enter to keep playing");
                        Console.ReadLine();
                        Start();

                    }

                }
                else if (managerInput == 3)
                {
                    Console.WriteLine("Which pet would you like to play with: Dog, Cat, Lion?");
                    petPlay = Console.ReadLine().ToUpper();
                    //mehod for playing with pets goes here
                    if (petPlay == "DOG")
                    {
                        //method for PLay pets
                        manager.Play();
                        petOne.Playing();
                        Console.WriteLine("Push enter to keep playing");
                        Console.ReadLine();
                        Start();


                    }
                    else if (petPlay == "CAT")
                    {
                        //method for PLay pets
                        manager.Play();
                        petOne.Playing();
                        Console.WriteLine("Push enter to keep playing");
                        Console.ReadLine();
                        Start();


                    }
                    else if (petPlay == "LION")
                    {
                        //method for PLay pets
                        manager.Play();
                        petOne.Playing();
                        Console.WriteLine("Push enter to keep playing");
                        Console.ReadLine();
                        Start();


                    }

                }
                else if (managerInput == 4)
                {
                    //method for paying for bills
                    manager.PayBills();
                    Console.WriteLine("Push enter to keep playing");
                    Console.ReadLine();
                    Start();

                }
                else if (managerInput == 5)
                {

                    //method for quitting goes here
                }
                else
                {
                    Console.WriteLine("please enter a number between 1-5");
                    Console.WriteLine("Push enter to keep playing");
                    Console.ReadLine();
                    Start();

                }
            }


            //Volunteer
            else if (userInput == 2)
            {
                Volunteer volunteer = new Volunteer();
                Console.Clear();
                Console.WriteLine("Thank you for volunteering at Lewis' animal house!");
                Console.WriteLine("Please enter  your name");
                string volName = Console.ReadLine();
                volunteer.VolunteerName = volName;

                Console.Clear();
                Console.WriteLine("Thanks for volunterring " + volunteer.VolunteerName + "!");
                Console.WriteLine("This is the status of your pets: ");
                Console.WriteLine("\n");
                petOne.SeePetInfo();
                Console.WriteLine("\n");
                Console.WriteLine("What you like to do next?");
                Console.WriteLine("\n");
                Console.WriteLine("1. Feed the pets");
                Console.WriteLine("2. Give pets water");
                Console.WriteLine("3. Play with the pet");
                Console.WriteLine("4. Quit");
                volunteerInput = int.Parse(Console.ReadLine());
                Console.Clear();

                if (volunteerInput == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Which pet would you like to feed: type Dog, Cat, or Lion");
                    string volPick = Console.ReadLine().ToUpper();
                    petOne.SeePetInfo();
                    Console.WriteLine("\n");
                    Console.Clear();
                    if (volPick == "DOG")
                    {
                        Console.Clear();
                        volunteer.Feed();
                        petOne.Hungar -= 10;
                        petOne.Tick();
                        Console.WriteLine("\n");
                        petOne.SeePetInfo();
                        Console.WriteLine("Push enter to keep playing");
                        Console.ReadLine();
                        Start();

                    }
                    else if (volPick == "CAT")
                    {

                        Console.Clear();
                        volunteer.Feed();
                        petOne.Hungar -= 14;
                        Console.WriteLine("\n");
                        petOne.SeePetInfo();
                        Console.WriteLine("Push enter to keep playing");
                        Console.ReadLine();
                        Start();

                    }
                    else if (volPick == "Lion")
                    {
                        Console.Clear();
                        volunteer.Feed();
                        petOne.Hungar -= 11;
                        Console.WriteLine("\n");
                        petOne.SeePetInfo();
                        Console.WriteLine("Push enter to keep playing");
                        Console.ReadLine();
                        Start();

                    }
                }
                else if (volunteerInput == 2)
                {
                    Console.WriteLine("Which pet would you like to give wat to: TYpe Dog, Cat, or Lion");
                    string volPick = Console.ReadLine().ToUpper();
                    petOne.SeePetInfo();
                    Console.WriteLine("\n");
                    if (volPick == "DOG")
                    {
                        Console.Clear();
                        volunteer.Water();
                        petOne.Energy -= 10;
                        petOne.Tick();
                        Console.WriteLine("\n");
                        petOne.SeePetInfo();
                        Console.WriteLine("Push enter to keep playing");
                        Console.ReadLine();
                        Start();

                    }
                    else if (volPick == "CAT")
                    {

                        Console.Clear();
                        volunteer.Water();
                        petOne.Energy -= 14;
                        Console.WriteLine("Push enter to keep playing");
                        Console.ReadLine();
                        Start();
                    }

                    else if (volPick == "LION")
                    {
                        Console.Clear();
                        volunteer.Water();
                        petOne.Energy -= 11;
                        Console.WriteLine("Push enter to keep playing");
                        Console.ReadLine();
                        Start();
                    }

            else if (volunteerInput == 3)
                    {
                        Console.WriteLine("Which pet would you like to play with: Dog Cat, Or Lion");
                        string playPet = Console.ReadLine().ToUpper();
                        if (playPet == "DOG")
                        {

                           
                            //volunteer play with pet
                            Console.Clear();
                            volunteer.Play();
                            petOne.PPaying();
                            Console.WriteLine("Push enter to keep playing");
                            Console.ReadLine();
                            Start();
                        }
                        else if(playPet == "CAT")
                        {
                            
                        }

                    }
                    else if (volunteerInput == 4)
                    {
                        //method for quitting
                    }
                    else
                    {
                        Console.WriteLine("Please enter number between 1-4");
                        Console.WriteLine("Push enter to keep playing");
                        Console.ReadLine();
                        Start();
                    }


                }

            }
        }


//***********************************************************************************************************************//

            //RESTART METHOD BELOW>>>>>> Coulnt get the do while looping working

            /// Start method to restart game.....
        public static void Start()
        {

            VirtualPetShelter animalHouse = new VirtualPetShelter();
            Pets petOne = new Pets();
            Manager manager = new Manager();


            int userInput;
            int managerInput;
            int volunteerInput;
            string petType;
            string petFeed;
            string petPlay;


            Console.WriteLine("Welcome to the Lewis animal house. What employee type are you?");
            Console.WriteLine("1. Manager");
            Console.WriteLine("2. Volunteer");
            userInput = int.Parse(Console.ReadLine());



            if (userInput == 1)
            {
                Console.Clear();
                Console.WriteLine("Thank you for working at Lewis' animal house");
                Console.WriteLine("\n");
                Console.WriteLine("what would you like to do?");
                Console.WriteLine("1. Adopt a pet");
                Console.WriteLine("2. Feed the pets");
                Console.WriteLine("3. Play with the pet");
                Console.WriteLine("4. Pay the bills");
                Console.WriteLine("5. quit");
                managerInput = int.Parse(Console.ReadLine());
                Console.Clear();
                if (managerInput == 1)
                {
                    Console.Clear();
                    petOne.SeePetInfo();
                    Console.WriteLine("What type of pet would you like to adopt: Dog, Cat, Lion?");//type of pet
                    petType = Console.ReadLine().ToUpper();
                    if (petType == "DOG")
                    {

                        //method for adopt pet goes here
                        Console.Clear();
                        petOne.DogAdopted();
                        Console.WriteLine("Push enter..");
                        Console.ReadLine();
                        //Start();



                    }
                    else if (petType == "CAT")
                    {
                        //method for apodting cat
                        Console.Clear();
                        petOne.CatAdopted();

                    }
                    else if (petType == "LION")
                    {
                        //method for apoting Lion goes here 
                        Console.Clear();
                        petOne.LionAdopted();

                    }
                }

                else if (managerInput == 2)
                {
                    Console.WriteLine("Which animal would you like to feed: Dog, Cat, Lion? ");
                    petFeed = Console.ReadLine().ToUpper();
                    if (petFeed == "DOG")
                    {
                        //method for feeding pets

                        manager.Feed();
                        petOne.Eating();
                        Console.WriteLine("\n");
                        petOne.SeePetInfo();

                    }
                    else if (petFeed == "CAT")
                    {
                        //method for feeding pets
                        manager.Feed();
                        petOne.Eating();
                        Console.WriteLine("\n");
                        petOne.SeePetInfo();
                    }

                    else if (petFeed == "LION")
                    {
                        //method for feeding pets
                        manager.Feed();
                        petOne.Eating();
                        Console.WriteLine("\n");
                        petOne.SeePetInfo();

                    }

                }
                else if (managerInput == 3)
                {
                    Console.WriteLine("Which pet would you like to play with: Dog, Cat, Lion?");
                    petPlay = Console.ReadLine().ToUpper();
                    //mehod for playing with pets goes here
                    if (petPlay == "DOG")
                    {
                        //method for PLay pets
                        manager.Play();
                        petOne.Playing();


                    }
                    else if (petPlay == "CAT")
                    {
                        //method for PLay pets
                        manager.Play();
                        petOne.Playing();


                    }
                    else if (petPlay == "LION")
                    {
                        //method for PLay pets
                        manager.Play();
                        petOne.Playing();


                    }

                }
                else if (managerInput == 4)
                {
                    //method for paying for bills
                    manager.PayBills();

                }
                else if (managerInput == 5)
                {

                    //method for quitting goes here
                }
                else
                {
                    Console.WriteLine("please enter a number between 1-5");

                }
            }


            //Volunteer
            else if (userInput == 2)
            {
                Volunteer volunteer = new Volunteer();
                Console.Clear();
                Console.WriteLine("Thank you for volunteering at Lewis' animal house!");
                Console.WriteLine("Please enter  your name");
                string volName = Console.ReadLine();
                volunteer.VolunteerName = volName;

                Console.Clear();
                Console.WriteLine("Thanks for volunterring " + volunteer.VolunteerName + "!");
                Console.WriteLine("This is the status of your pets: ");
                Console.WriteLine("\n");
                petOne.SeePetInfo();
                Console.WriteLine("\n");
                Console.WriteLine("What you like to do next?");
                Console.WriteLine("\n");
                Console.WriteLine("1. Feed the pets");
                Console.WriteLine("2. Give pets water");
                Console.WriteLine("3. Play with the pet");
                Console.WriteLine("4. Quit");
                volunteerInput = int.Parse(Console.ReadLine());
                Console.Clear();

                if (volunteerInput == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Which pet would you like to feed: type Dog, Cat, or Lion");
                    string volPick = Console.ReadLine().ToUpper();
                    petOne.SeePetInfo();
                    Console.WriteLine("\n");
                    Console.Clear();
                    if (volPick == "DOG")
                    {
                        Console.Clear();
                        volunteer.Feed();
                        petOne.Hungar -= 10;
                        petOne.Tick();
                        Console.WriteLine("\n");
                        petOne.SeePetInfo();

                    }
                    else if (volPick == "CAT")
                    {

                        Console.Clear();
                        volunteer.Feed();
                        petOne.Hungar -= 14;
                        Console.WriteLine("\n");
                        petOne.SeePetInfo();

                    }
                    else if (volPick == "Lion")
                    {
                        Console.Clear();
                        volunteer.Feed();
                        petOne.Hungar -= 11;
                        Console.WriteLine("\n");
                        petOne.SeePetInfo();

                    }
                }
                else if (volunteerInput == 2)
                {
                    Console.WriteLine("Which pet would you like to give wat to: TYpe Dog, Cat, or Lion");
                    string volPick = Console.ReadLine().ToUpper();
                    petOne.SeePetInfo();
                    Console.WriteLine("\n");
                    if (volPick == "DOG")
                    {
                        Console.Clear();
                        volunteer.Water();
                        petOne.Energy -= 10;
                        petOne.Tick();
                        Console.WriteLine("\n");
                        petOne.SeePetInfo();

                    }
                    else if (volPick == "CAT")
                    {

                        Console.Clear();
                        volunteer.Water();
                        petOne.Energy -= 14;
                    }

                    else if (volPick == "LION")
                    {
                        Console.Clear();
                        volunteer.Water();
                        petOne.Energy -= 11;
                    }

                    else if (volunteerInput == 3)
                    {
                        //volunteer play with pet
                        Console.Clear();
                        volunteer.Play();
                        petOne.Tick();

                    }
                    else if (volunteerInput == 4)
                    {
                        //method for quitting
                    }
                    else
                    {
                        Console.WriteLine("Please enter number between 1-4");
                    }


                }

            }

        }
    }
}
           