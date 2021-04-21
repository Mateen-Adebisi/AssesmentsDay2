using System;

namespace Numbe2
{
    class Program
    {
        static void Main(string[] args)
        {
           int Total = 0;

           int Ave = 0;

            Console.Write("How many numbers");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for(int i=0;i<numbers.Length;i++)
            {
                Console.Write("Number {0}: ", i + 1);
                numbers[i] = int.Parse(Console.ReadLine());
                Ave += numbers[i];
            }

            Ave = Total / numbers.Length;

            Console.WriteLine("total : "+Total);
            Console.WriteLine("Ave : "+Ave);
            
        }
    }
}
