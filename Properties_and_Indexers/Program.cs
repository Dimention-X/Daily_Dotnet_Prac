// properties are the extension to the fields, uses accessors for the set and get the value for the field. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_and_Indexers
{
    public class Student
    {
        private string code = "N.A";
        private string name = "N.A";
        private int age = 0;

        public int Age { get { return age; } set { age = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Code { get { return code; } set { code = value; } }

        public override string ToString()
        {
            return "Code = " + Code +"\n" + "Name =" + Name + "\n" + "Age =" + Age;
        }
    }

    class Program
    {
       static void Main(string[] args)
        {
            Student s = new Student();
            s.Code = "C#";
            s.Name = "Akhilesh KS";
            s.Age = 24;
            Console.WriteLine(s);     
        }
    }
}
