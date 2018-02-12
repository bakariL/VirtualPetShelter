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
                    petFeed = Console.ReadLine();
                    if (petFeed == "Dog")
                    {
                        //method for feeding pets

                    }
                    else if (petFeed == "Cat")
                    {
                        //method for feeding pets
                    }
                    else if (petFeed == "Lion")
                    {
                        //method for feeding pets
                    }

                }
                else if (managerInput == 3)
                {
                    Console.WriteLine("Which pet would you like to play with: Dog, Cat, Lion?");
                    petPlay = Console.ReadLine();
                    //mehod for playing with pets goes here
                    if (petPlay == "Dog")
                    {
                        //method for PLay pets

                    }
                    else if (petPlay == "Cat")
                    {
                        //method for PLay pets
                    }
                    else if (petPlay == "Lion")
                    {
                        //method for PLay pets
                    }

                }
                else if (managerInput == 4)
                {
                    //method for paying for bills
                    Console.WriteLine("Bills have been Paid!");
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



            //else if (userInput == 2)
            //{
            //    Console.WriteLine("Thank you for volunteering at Lewis' animal house!");
            //    Console.WriteLine("\n");
            //    Console.WriteLine("This is the status of your pets: ");
            //    //method call here
            //    Console.WriteLine("What you like to do next?");
            //    Console.WriteLine("\n");
            //    Console.WriteLine("1. Feed the pets");
            //    Console.WriteLine("2. Give pets water");
            //    Console.WriteLine("3. Play with the pet");
            //    Console.WriteLine("4. Quit");
            //    volunteerInput = int.Parse(Console.ReadLine());

            //
            }
        public static void Start()
        {
            VirtualPetShelter animalHouse = new VirtualPetShelter();
            Pets petOne = new Pets();

            //    foreach (Object Pets in petList)
            //    {

            //        Console.WriteLine(Pets);
            //    }

            List<Pets> petsList = new List<Pets>() {
            new Pets() { Name = "Barki" }
            };

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
                    petFeed = Console.ReadLine();
                    if (petFeed == "Dog")
                    {
                        //method for feeding pets

                    }
                    else if (petFeed == "Cat")
                    {
                        //method for feeding pets
                    }
                    else if (petFeed == "Lion")
                    {
                        //method for feeding pets
                    }

                }
                else if (managerInput == 3)
                {
                    Console.WriteLine("Which pet would you like to play with: Dog, Cat, Lion?");
                    petPlay = Console.ReadLine();
                    //mehod for playing with pets goes here
                    if (petPlay == "Dog")
                    {
                        //method for PLay pets

                    }
                    else if (petPlay == "Cat")
                    {
                        //method for PLay pets
                    }
                    else if (petPlay == "Lion")
                    {
                        //method for PLay pets
                    }

                }
                else if (managerInput == 4)
                {
                    //method for paying for bills
                    Console.WriteLine("Bills have been Paid!");
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



            //else if (userInput == 2)
            //{
            //    Console.WriteLine("Thank you for volunteering at Lewis' animal house!");
            //    Console.WriteLine("\n");
            //    Console.WriteLine("This is the status of your pets: ");
            //    //method call here
            //    Console.WriteLine("What you like to do next?");
            //    Console.WriteLine("\n");
            //    Console.WriteLine("1. Feed the pets");
            //    Console.WriteLine("2. Give pets water");
            //    Console.WriteLine("3. Play with the pet");
            //    Console.WriteLine("4. Quit");
            //    volunteerInput = int.Parse(Console.ReadLine());

            //

        }

    }
    }