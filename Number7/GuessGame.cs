using System;

namespace Number7
{
    public class GuessGame
    {
        static void Main(string[] args)
        {
            Console.WriteLine(theRealRoot(3));
        }

        public static double theRealRoot(long n) 
        {
            double lastGuess;
            double nextGuess = 1;

            do {
                lastGuess = nextGuess;
                nextGuess = (lastGuess + n / lastGuess) / 2;
            } while (lastGuess - nextGuess >= 0.0001 || nextGuess - lastGuess >= 0.0001);

            return nextGuess;
        }
    }  
}