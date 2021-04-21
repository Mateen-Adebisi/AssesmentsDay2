using System;

namespace Number6
{
    class Program
    {
        static void Main(string[] args)
        {
            String old = "aeiou";
            char[] characters = old.ToCharArray();

            string Clear = "Webpage";
            char[] letters = Clear.ToCharArray();
            char x = new char { };
            
            for (int i = 0; i < letters.Length; i++)
            {
                if ((letters[i] == 'a') | (letters[i] == 'e' ) | (letters[i] == 'i' ) | (letters[i] == 'o' ) | (letters[i] == 'u'))
                {
                    for (int s = 0; s < letters.Length - 1; s++)
                    {
                        x = letters[s];
                        letters[s] = letters[s + 1];
                        letters[s + 1] = x;
                    }
                }
            }
            string st = new string(letters);
            Console.WriteLine(st);
        }
    }
}  

