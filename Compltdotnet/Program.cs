using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compltdotnet
{
    class Program : Portal                     // Employee
    {
        public static void Add<T>(T a, T b)
        {

            bool d = a.Equals(b);
            if (d == true)
                Console.WriteLine(" a and b are equal");
            else
                Console.WriteLine(" a and b are not equal");
            Console.ReadKey();
        }

        public static void Main()
        {
            // Add("Akhilesh","Akhilesh");

            Program p = new Program();
            //p.Salary();
            //Console.ReadKey();
            p.ExeEmployeee();

        }
    }

    class Company
    {
        public virtual void Salary()
        {
            Console.WriteLine("Salary of an employee");
        }
    }

    abstract class Exemployee
    {
        public abstract void ExeEmployeee();
    }

    class Portal : Exemployee
    {
        public override void ExeEmployeee()
        {
            // throw new NotImplementedException();
            Console.WriteLine("The abstract Methods are here");
        }

    }


    class Employee : Company
    {
        public override void Salary()
        {
            base.Salary();
            //  Console.WriteLine(" Employee class Methods Colled after overriden");
        }


    }


}
