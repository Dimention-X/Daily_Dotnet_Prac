using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genrics
{
    class Add<T>
    {
        public void dsa (T j,T k)
        {
            if (j.Equals(k))
                Console.WriteLine(" j is eqlual to k");
            else
                Console.WriteLine(" j is not equal to k");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // callingAddMethodMainBlock();
            NumberChanger<int> intt = new NumberChanger<int>(GenricDeligate.AddNum);
            NumberChanger<int> mull = new NumberChanger<int>(GenricDeligate.MultNum);
            intt(12);
            Console.WriteLine("Delegate 1 ",GenricDeligate.getNum());
            mull(21);
            Console.WriteLine("Delegate 2", GenricDeligate.getNum());
            Console.ReadKey();

           
        }

        private static void callingAddMethodMainBlock()
        {
            int a, b;
            Add<int> ik = new Add<int>();
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            ik.dsa(a, b);

            Add<string> ik2 = new Add<string>();
            string str1, str2;
            str1 = Console.ReadLine();
            str2 = Console.ReadLine();
            ik2.dsa(str1, str2);
        }
    }
}
