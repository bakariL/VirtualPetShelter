using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VpShelter
{
   public  class  Manager : Employee
    {

        private int salary = 10000;
        //properties

            public int Salary { get; set; }


        //contructors
        public Manager()
        {
            //default
        }

        public Manager(int salary)
        {
            Salary = salary;
        }

        //methods
        //feed it 
        public override void Feed()
        {
            Console.WriteLine("Thanks, that was yummy!" );
            
        }
        //thirst
        public override void Water()
        {
            Console.WriteLine("That was refreshing to drink!");
        }
        //play
        public override void Play()
        {
            Console.WriteLine("That was fun! thanks for playing with me");
        }
        //quit

        public override void Quit()
        {
            Console.WriteLine("thank you for playing");
        }
        //adopt
        public static void Adopt()
        {
            Console.WriteLine("Thanks for aopting me!");
        }
        //pay the bills
        public  void PayBills()
        {
            Console.WriteLine("Bills are PAID!! YAY!!!");
        }


    }
}
