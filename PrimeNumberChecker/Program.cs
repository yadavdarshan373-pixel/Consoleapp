using System;
class InputNumber
{
    int number;
    public void GetNumber()
    {
        Console.WriteLine("--- Prime Number Checker ---");
        Console.WriteLine("(Press Enter on an empty line to exit)\n");
        while (true)
        {
            Console.Write("Enter the number: ");
            string? input = Console.ReadLine() ;
            if (string.IsNullOrEmpty(input))
            {
               Console.WriteLine("Exiting Program...");
                return;
            }
           if (int.TryParse(input ,out number))
            {
                PrimeCheck(number);
            }
            else
            {
                Console.WriteLine("Something went wrong! Please enter a valid intiger.\n");
            }
        }
    }
    public void PrimeCheck(int number)
    {
        if (number <= 1)
        {
            Console.WriteLine($"{number} is not a prime number.\n");
            return;
        }

        bool isPrime = true;
        for (int i = 2; i*i <= number; i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }
        if (isPrime)
        {
            Console.WriteLine($"{number} is a prime number.\n");
        }
        else
        {
            Console.WriteLine($"{number} is not a prime number.\n");
        }
    }
}
class Program
{
    public static void Main(string[] args)
    {
        InputNumber  inobj = new InputNumber();
        inobj.GetNumber();
    }
}