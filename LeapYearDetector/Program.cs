using System;

class Leapyear
{
    private int year;

    public bool Input()
    {
        while (true)
        {
            Console.Write("Enter a four-digit year\nOr type exit/end/quit to stop: ");
            string? input = Console.ReadLine();

            if (input is null)
            {
                return false;
            }

            input = input.Trim();
            if (input.Equals("exit", StringComparison.OrdinalIgnoreCase)
                || input.Equals("end", StringComparison.OrdinalIgnoreCase)
                || input.Equals("quit", StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }

            if (input.Length == 4 && input.All(char.IsAsciiDigit)
                && int.TryParse(input, out year) && year > 0)
            {
                return true;
            }

            Console.WriteLine("Invalid year. Enter a four-digit year.");
        }
    }

    public void Display()
    {
        if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
        {
            Console.WriteLine("    ------------------  ");
            Console.WriteLine($"   {year} is a Leap Year.");
            Console.WriteLine("    ------------------");
        }
        else
        {
            Console.WriteLine("     ---------------------");
            Console.WriteLine($"    {year} is not a Leap Year.");
            Console.WriteLine("     ----------------------");
        }
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("------  Leap year check  ------\n");
        Leapyear leapYear = new Leapyear();
        while (leapYear.Input())
        {
            leapYear.Display();
        }
        Console.WriteLine("------ Thanks for using this app! --------");
    }
}