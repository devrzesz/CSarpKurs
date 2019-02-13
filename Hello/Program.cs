using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = args[0];

            Console.Write("Witaj, " + name);

            //foreach (var item in args)
            //{
            //    Console.WriteLine("Witaj, " + item);
            //}
        }
    }
}
