using System;
using System.Globalization;
namespace EvenOddCheck
{
    class UserInput
    {
        public int len ;
        public int[] numbers = Array.Empty<int>();

        public UserInput()
        {
            Console.WriteLine("Check for Even or Odd.\n");
        }
         public void GetInput()
        {
            while (true)
            {
                Console.Write("Enter Length of the array: ");
                if (int.TryParse(Console.ReadLine(), out len) && len > 0)
                {
                    numbers = new int[len];
                    break;
                }
                Console.WriteLine("Please Enter a valid size!");
            }            
        }
        public void CreateArray()
        {
            for (int i = 0; i < len; i++)
            {
                // Force valid integers for each element of the array
                while (true)
                {
                    Console.Write($"Element {i}: ");
                    if (int.TryParse(Console.ReadLine(), out numbers[i]))
                    {
                        break;
                    }
                    Console.WriteLine("Invalid number. Please try again.");
                }
            }
            Console.WriteLine($"\nThe Array Elements are: {string.Join(", ", numbers)}");
        }
        public void Display()
        {
            int CountEven = 0;
            int CountOdd = 0;
            Console.WriteLine("\n--- Result ---");
            foreach (int number in numbers)
            {
                
                if (number % 2 == 0)
                {
                    Console.WriteLine($"{number} is Even");
                    CountEven ++;
                }
                else
                {
                    Console.WriteLine($"{number} is Odd");
                    CountOdd ++;
                }
            }
            Console.WriteLine($"Even Count is : {CountEven}");
            Console.WriteLine($"Odd Count is : {CountOdd}");
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            UserInput us1 = new UserInput();
            us1.GetInput();
            us1.CreateArray();
            us1.Display();
        }
    }
}