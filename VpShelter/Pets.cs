using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
