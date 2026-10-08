using System;
class MultiplicationTable
{
    int number;
    public void GetInput()
    {
         while (true) 
        { 
            Console.Write("Enter the number for the multiplication table: "); 
            if (int.TryParse(Console.ReadLine(), out number)) 
            { 
                break; 
            } 
            Console.WriteLine("Oops! That's not a valid integer. Try again."); 
        } 
    }
    public void Output()
    {
        
        Console.WriteLine($"\nMultiplication Table for(number)");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{number} x {i} = {number * i}");
        }
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("-----------------------------------------------------");
        Console.WriteLine("----  Multiplication Table Generator  ----");
        Console.WriteLine("-----------------------------------------------------\n");
        MultiplicationTable table = new MultiplicationTable();
        table.GetInput();
        table.Output();
    }
}
