using System;

namespace Number10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
                   string userInput = Console.ReadLine();



            for (int i = 0; i < userInput.Length; i++)
            {

                userInput = userInput.Replace(userInput[i], Vowel(userInput[i]));
            }

            
        }

        public static char Vowel(char v)
        {
            if(v == 'a')
            {
                return 'e'; 
            }
            else if (v == 'e')
            {
                return 'i';
            }
            else if (v == 'i')
            {
                return 'o';
            }
            else if (v == 'o')
            {
                return 'u';
            }
            else if (v == 'u')
            {
                return 'a';
            }
            else
            {
                return v;
            }    }
    }
}
