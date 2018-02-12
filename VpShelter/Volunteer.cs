using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VpShelter
{
    public  class Volunteer : Employee
    {
      
       
        //props
        public string VolunteerName { get; set; }

        //contrictor

        public Volunteer()
        {
            //default
        }

        public Volunteer( string volunteername)
        {
           
            this.VolunteerName = volunteername;
        }

        //methods
        //feed it
        public override void Feed()
        {
            Console.WriteLine("You have feed me");
        }

        //to play 
        public override void Play()
        {
            Console.WriteLine("Thanks for playing with me!");
        }

        // Thrist
        public override void Water()
        {
            Console.WriteLine("That was some good Water!");

        }

        public override void Quit()
        {
            Console.WriteLine("Thanks for playing!");
        }


    }
    }


