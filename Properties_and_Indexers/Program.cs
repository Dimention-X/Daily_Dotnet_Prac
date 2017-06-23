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


            // Operation => 1 Student class  

            Student s = new Student();
            s.Code = "C#";
            s.Name = "Akhilesh KS";
            s.Age = 24;
            Console.WriteLine(s);     

            /* Operations 2,3,4 types of Prop
             * 1> Reda Only Porp. => Accomplished by only heaving a get accessor.
             * 2> Write only prop. => Accomplised by only heaving the set accssor.
             * 3> R/W porp. => both the get and set accssor.
             */

            Console.WriteLine("************************* Indexers ******************************************");

            IndexerClass obj = new IndexerClass(5);
            for (int i = 0; i < obj.length; i++)
			{
                Console.Write(obj[i]+"");
                Console.WriteLine();
			}

            // inserting the data in the indexed object arry.

            for (int i = 0; i < obj.length; i++)
			{
                  obj[i]=(Convert.ToInt32)Console.ReadLine();
			}

            // showing the inseted data.

            for (int i = 0; i < obj.length; i++)
			{
                Console.WriteLine(obj[i]);
			}
        }

        
    }

    class IndexerClass
    {
        int[] arr;
        public IndexerClass(int size)
        {
            arr = new int[size];
        }
    }
}
