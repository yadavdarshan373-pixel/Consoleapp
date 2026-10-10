using System;
class Checker
{
    string? stringtocheck;
    public void GetString()
    {
        while (true)
        {
            Console.Write("Enter the string: ");
            stringtocheck = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(stringtocheck))
            {
                return;
            }
            Console.WriteLine("OOps! Something went wrong!");
        }
    }
    public string CheckReverse()
    {
        string value = stringtocheck ?? string.Empty;
        int lenght = value.Length;
        string reverse = string.Empty;
        for (int i = lenght -1; i >= 0; i--)
        {
            reverse += value[i] ;
        }
        return reverse;
    }
    public void Display()
    {
        if (stringtocheck == CheckReverse())
        {
            Console.WriteLine($"{stringtocheck} IS a Panindrome");
        }
        else
        {
            Console.WriteLine($"{stringtocheck} Not a Palindrome.");
        }
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Checker myobj = new Checker();
        myobj.GetString();
        myobj.CheckReverse();
        myobj.Display();
    }
}