using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualDog;

namespace VpShelter
{
   public class Pets : VirtualPet
    {
        //feilds
        //properties

        public string Dog { get; set; }
        public string Cat { get; set; } 
        public string Lion { get; set; }
        public string DogFood { get; set; }
        public string CatFood { get; set; }
        public string RawMeat { get; set; }

            //constructor //ctor

            public Pets()
        {
                //default
        }
        public Pets( string dog, string cat, string lion, string dogfood, string catfood, string rawmeat)
        {
            this.Dog = dog;
            this.Cat = cat;
            this.Lion = lion;
            this.DogFood = dogfood;
            this.CatFood = catfood;
            this.RawMeat = rawmeat;
            
        }


        //methods...none right now

        public void SeePetInfo()
        {
            Dog = "KillerDog";
            Cat = "HelloKitty";
            Lion = "SimbaLion";
            DogFood = "GunPowder";
            CatFood = "MeowMix";
            RawMeat = "Aspargus";
            

            Console.WriteLine("Name      |Hungar    |Thrist   | Boredom");
            Console.WriteLine( "_______ __| _________|_________|_________");
            Console.WriteLine(  Dog + "      " + Hungar+  "           " +"" +Energy +"         "+ Isbord );
            Console.WriteLine("----------|---------- |----------|----------");
            Console.WriteLine(Cat + "      " + Hungar + "           " + "" + Energy + "         " + Isbord);
            Console.WriteLine("----------| ----------|----------|----------|");
            Console.WriteLine(Lion + "      " + Hungar + "           " + "" + Energy + "         " + Isbord);
            Console.WriteLine("---------|---------|---------|------------");
            Console.WriteLine("\n");


        }

        public void DogAdopted()
        {
            Console.WriteLine("Congrats! You have apodted " + Dog + " please feed him " + DogFood);
        }

        public void CatAdopted()
        {
            Console.WriteLine("Congrats! You have apodted " + Cat + " please feed him " + CatFood);
        }

        public void LionAdopted()
        {
            Console.WriteLine("Congrats! You have apodted " + Lion + " please feed him " + RawMeat);
        }
    }
}
