using System;

namespace exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            //mata in sitt namn.
            Console.WriteLine("Skriv ditt namn");
            string namn = Console.ReadLine();
            // hälsar du användaren välkommen.
            // användaren mata in sin ålder 
            Console.WriteLine("Var hälsad "+ namn+"!\n När är du född?(YYYY-MM-DD");
            // och spara undan den i lämplig variabel.
            string ålder = Console.ReadLine();
            DateTime år = DateTime.Parse(ålder);
            TimeSpan årdagar= DateTime.Now.Subtract(år);
            // Räkna sedan ut antalet dagar levt vid angiven ålder.
            //for(int i=0; i<år)
            // Presentera resultat.
            int dagar = Convert.ToInt32(årdagar.TotalDays);
            Console.WriteLine("Du är "+ dagar+" dagar gammal!");
            Console.ReadLine();
        }
    }
}
