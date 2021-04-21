using System;

namespace Number1
{
    class Program
    {
        static void Main(string[] args)
        {
            
			int i, index = 0, Place = 0;

			int[] arr = new int[5];

			Console.Write("Enter five numbers: ");

			for (i = 0; i < arr.Length;)
			{
				i++;
				arr[i] = Convert.ToInt32(Console.ReadLine());
			}

		    for (i = 0; i < 5; i++)
			{
				if (arr[i] % 2 == 0)
				{
						index = index + arr[i];
				}
				else
				{
						Place = Place + arr[i];
				}
			}
			Console.WriteLine("even list:" + index);
			Console.WriteLine("odd list:" + Place);

        }
    }
}
