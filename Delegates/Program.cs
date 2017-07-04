using System;
namespace Delegates
{

    class Program 
    {
        public delegate int Mycustom(int x, int y);

        public static int Add(int x, int y) { return x + y; }

        public static  int Subs(int x, int y) { return x - y; }

        public int MyProperty { get; set; }
        static void Main(string[] args)
        {
            Mycustom cmd = new Mycustom(Program.Subs);   // single delgates simply calls the methord inside it.
            Console.WriteLine(cmd(12,12));      
            Mycustom cmd2 = new Mycustom(Program.Add);
            Console.WriteLine(cmd2(12,23));
            Mycustom cmd3 = cmd;                 // muticast delegates , delegates inside the delegate . moreever used in the Event handlng 
            Console.WriteLine("Multicast delegates : "+ cmd3(23,34)); 
        }
    }

    
}
