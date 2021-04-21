using System;


namespace number3
{
    class Lottery
    {
        public static void MyLottery()
        {
            int lot1 = 24;

            int lot2 = 23;

            int lot3 = 32;

            Console.WriteLine("Enter Three Numbers To Win ");
            int Num1 = int.Parse(Console.ReadLine());

            int Num2 = int.Parse(Console.ReadLine());

            int Num3 = int.Parse(Console.ReadLine());

            if ((Num1 == lot2 || Num1 == lot3) || (Num2 == lot1 || Num2 == lot3) || (Num3 == lot1 || Num3 == lot2))
            {
                Console.WriteLine("you Won $1,000 ");
                Console.WriteLine("Enter any key");
                Console.ReadKey();
            }
            else if ((Num2 == lot1 || Num2 == lot2 || Num2 == lot3) && (Num1 == lot1 || Num1 == lot2 || Num1 == lot3) && (Num3 == lot1 || Num3 == lot2 || Num3 == lot3))
            {
                Console.WriteLine("you Won $3,000 ");
                Console.WriteLine("Enter any key");
                Console.ReadKey();
            }
            else if ((Num1 == lot1) && (Num2 == lot2) && (Num3 == lot3))
            {
                Console.WriteLine("you Won $10,000 ");
                Console.WriteLine("Enter any key");
                Console.ReadKey();
            }
            else
            {

                Console.WriteLine("Invalid inpute");
            }




        }
    }        

        
         
}