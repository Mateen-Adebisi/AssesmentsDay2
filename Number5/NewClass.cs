using System;

namespace Number5
{
    public class NewClass
    {
        public static int Revers(int num)
        {
            int rev = 0;
            while (num > 0) {
                rev = rev * 10 + num % 10;
                num = num / 10;
            }
            return rev;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number to check");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Reverse of number is " + Revers(num));
        }
    }
}