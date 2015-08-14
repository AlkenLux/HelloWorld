using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Out.WriteLine("HelloWorld");
            Console.Out.WriteLine("HelloWorld");
            Console.Out.WriteLine("HelloWorld");

            var toto = new []{ "toto" , "tata", "titi" };
            
            foreach (var i in toto)
            {
                Console.Out.WriteLine("{0}", i);

            }
            Console.Read();
        }
    }
}
