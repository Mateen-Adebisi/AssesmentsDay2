using System;

namespace Number2
{
    class Program
    {
        static void Main(string[] args)
        {
           int sum=0, avg=0;
            Console.Write("How many numbers you want to enter?");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for(int i=0;i<numbers.Length;i++)
            {
                Console.Write("Number {0}: ", i + 1);
                numbers[i] = int.Parse(Console.ReadLine());
                sum += numbers[i];
            }
            avg = sum / numbers.Length;
            Console.WriteLine("The Sum is : "+sum);
            Console.WriteLine("The Average is : "+avg);
            
            Console.ReadKey();


        }
    }
}
