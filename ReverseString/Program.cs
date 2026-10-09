using System;
using System.Dynamic;
class ReverseString
{
    string originalstring =string.Empty;
    string copystring =string.Empty;
    string reversestring = string.Empty;
    public void GetInput()
    {   
      while(true)
      {
        Console.Write("Enter the string: ");
        originalstring = Console.ReadLine() ?? string.Empty;
        if (!string.IsNullOrWhiteSpace(originalstring))
        {
            return;
        }
      }
    }
    public string GetReverse()
    {
        copystring = originalstring;
        for(int i = copystring.Length-1; i >= 0; i--)
        {
            reversestring += originalstring[i];
        }
        return reversestring;
    }
    public void Display()
    {
        Console.WriteLine($"The Original string is : {originalstring}\n");
        Console.WriteLine($"The Reverse string is :{GetReverse()}");
    }
}
class Program
{
    public static void Main(String[] args)
    {
        ReverseString reverseobject = new ReverseString();
        reverseobject.GetInput();
        reverseobject.Display();
    }
}