using System;

namespace exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Mata in namn på karaktär ett:");
                    string namn1 = Console.ReadLine();
                    Console.WriteLine("Skriv in namn på karaktär 2: ");
                    string namn2 = Console.ReadLine();

                    Console.WriteLine(namn1 +" och "+ namn2+ " gick till en bar.");
                    Console.WriteLine(namn1 + " tog en öl och "+namn2+" tog en flaska absint");
                    Console.ReadLine();
        }
    }
}
