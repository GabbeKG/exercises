using System;

namespace exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
                    int heltal;
                    Console.WriteLine("skriv in ett decimal tal");
                    string str = Console.ReadLine();
                    float dec = (float)Convert.ToDouble(str);
                    heltal = Convert.ToInt32(dec);

                    Console.WriteLine("Närmsta heltal är: "+ heltal);
                    Console.ReadLine();
        }
    }
}
