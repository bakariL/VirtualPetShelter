using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VpShelter
{
    public abstract class Employee
    {
        //feilds



        //properties

        public int EmployeeID { get; set; }


        //contrustors
        public Employee()
        {
            //default constructor
        }


        public Employee(int employeeID )
        {
            this.EmployeeID = employeeID;
            
        }


        //2 abstract Methods
        public abstract void Feed();
        public abstract void Water();
        public abstract void Play();
        public abstract void Quit();
        


            

        
    }
}

