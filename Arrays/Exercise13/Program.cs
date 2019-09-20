using System;

namespace Exercise13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] siffror = new int[5];

            Console.WriteLine("skriv in 5 tal.");
            Console.Write("tal 1: ");
            string numEtt = Console.ReadLine();
            siffror[0] = Convert.ToInt32(numEtt);
            
            Console.Write("tal 2: ");
            string numTvå = Console.ReadLine();
            siffror[1] = Convert.ToInt32(numTvå);
            
            Console.Write("tal 3: ");
            string numTre = Console.ReadLine();
            siffror[2] = Convert.ToInt32(numTre);
            

            Console.Write("tal 4: ");
            string numFyra = Console.ReadLine();
            siffror[3] = Convert.ToInt32(numFyra);
            
            Console.Write("tal 5: ");
            string numFem = Console.ReadLine();
            siffror[4] = Convert.ToInt32(numFem);
            

                int sum=0;
            for(int i = 0; i<siffror.Length; i++){
                sum = sum+siffror[i];
                //Console.WriteLine("inlagd siffra: " +siffror[i]);
            }
               
                Console.WriteLine("summan: "+sum);
                 Console.ReadLine();
        }
    }
}
