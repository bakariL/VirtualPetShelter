using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VpShelter
{
    class Program
    {
        public static string ListofPets { get; private set; }

        static void Main(string[] args)
        {
            VirtualPetShelter animalHouse = new VirtualPetShelter(ListofPets);
            


            int userInput;
            int managerInput;
            int volunteerInput;
            string petType;
            Console.WriteLine("Welcome to the Lewis animal house. What employee type are you?");
            Console.WriteLine("1. Manager");
            Console.WriteLine("2. Volunteer");
            userInput=int.Parse(Console.ReadLine());


            if (userInput == 1)
            {
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
                    Console.WriteLine("What type of pet would you like to adopt: Dog, Cat, Lion?");//type of pet
                    petType = Console.ReadLine().ToUpper();
                   if(petType == "Dog")
                    {
                        //method for adopt pet goes here
                        

                    }



                }
                else if(managerInput == 2)
                {
                    //method for feeding pets
                }
                else if(managerInput == 3)
                {
                    //mehod for playing with pets goes here
                }
                else if(managerInput == 4)
                {
                    //method for paying for bills
                }
                else if(managerInput == 5)
                {
                    //method for quitting goes here
                }
                else
                {
                    Console.WriteLine("please enter a number between 1-5");
                }

            }else if( userInput == 2)
            {
                Console.WriteLine("Thank you for volunteering at Lewis' animal house!");
                Console.WriteLine("\n");
                Console.WriteLine("This is the status of your pets: ");
                //method call here
                Console.WriteLine("What you like to do next?");
                Console.WriteLine("\n");
                Console.WriteLine("1. Feed the pets");
                Console.WriteLine("2. Give pets water");
                Console.WriteLine("3. Play with the pet");
                Console.WriteLine("4. Quit");
                volunteerInput = int.Parse(Console.ReadLine());

            }

            
            



        }
    }
}
