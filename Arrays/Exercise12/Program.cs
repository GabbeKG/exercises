using System;

namespace Exercise12
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namn = new string[5];

            Console.WriteLine("Hej skriv in fem namn.");

            Console.WriteLine("Namn 1: ");
            namn[0] = Console.ReadLine();
            Console.WriteLine("Namn 2: ");
            namn[1] = Console.ReadLine();
            Console.WriteLine("Namn 3: ");
            namn[2] = Console.ReadLine();
            Console.WriteLine("Namn 4: ");
            namn[3] = Console.ReadLine();
            Console.WriteLine("Namn 5: ");
            namn[4] = Console.ReadLine();

            for(int i = 0; i<namn.Length; i++){
            Console.WriteLine(namn[i]);
                
            }
            Console.WriteLine("byt namn")
            Console.ReadLine();
        }
    }
}
