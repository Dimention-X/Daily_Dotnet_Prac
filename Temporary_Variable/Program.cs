using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temporary_Variable
{
    class Program
    {
        public static int[] jam(ref int[] a)
        {
            a = new int[5] { 3, 4, 5, 6, 7 };
            return a;

        }
        static void Main(string[] args)
        {
            int[] a = new int[5];
            int[] b = new int[5];
            jam(ref a);
            Array.Copy(a, b, 5);
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
                Console.WriteLine(b[i]);
            }

        }


    }
}
