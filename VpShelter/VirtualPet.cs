using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VpShelter
{
   public class VirtualPet  //VirtualPet class

    {
        //Fields
        //private string name; //name of pet
        //private int energy; //energy
        //private int hungar; //feed
        //private bool isBord = true; //boredomn

        //Properties 4
        public string Name { get; set; }
        public int Thirst{get; set;  }
        public int Hungar{ get; set; }
        public bool IsBord { get; set; }
        

        //Contructors at least 1
        public VirtualPet()
        {
            //default
        }

        public VirtualPet(string name, int thrist, int hungar, bool isBord)
        {
            this.Name = name;
            this.Hungar = hungar;
            this.IsBord = isBord;
            this.Thirst = Thirst;
        } // where we create the animal with name and its description
     


        //Methods 3

        public static void Clear()
        {

        }


        //public void GetName(string name)
        //{
        //    this.Name = "BoBo";
        //}

        //public void GetSleep()
        //{
        //    Thirst += 35;
        //    Console.WriteLine("Engergy:" + Thirst);
        //}

        //public void Eat()
        //{
        //    Hungar += 20;
        //    Thirst += 10;
        //    Console.WriteLine("Hungar:" + Hungar);
        //}

        //public void Details() {
        //    {
        //        Name = Name;
        //        Hungar = Hungar;
        //        Thirst = Thirst;
        //        IsBord = IsBord;
                

        //        Console.WriteLine("Name |Hungar |Energy level |Bored ");
        //        Console.WriteLine("_ _ _|_ _ _ _|_ _ _ _ _ _ _|_ _ _ _");
        //        Console.WriteLine("" + Name + "  " + Hungar + "  " + Thirst + "" + IsBord);

            






        //public void Play()
        //{
        //    if (isBord)
        //    {
        //        Console.WriteLine("Play with me");
        //        energy -= 65;
        //        hungar -= 42;

        //    }
        //    else
        //    {
        //        Console.WriteLine("Im getting tired of playing.");
        //    }
        //}

        //public void Tick()
        //{
        //    if (isBord)
        //    {
        //        energy -= 12;
        //    }
        //    else
        //    {
        //        hungar -= 27;
        //    }
        //}

    }
}

    

