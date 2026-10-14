using System;
using System.Numerics;

class GetValue
{
    public double length;
    public double height;
    public double radius;
     public double GetValidDouble(string prompt)
    {
        double result;
        Console.Write(prompt);
        while (!double.TryParse(Console.ReadLine(), out result) || result <= 0)
        {
            Console.Write("Invalid input. Please enter a positive number: ");
        }
        return result;
    }
    public void GetData()
    {
        int shapechoice;
        do
        {
            Console.WriteLine("Select the shape:");
            Console.WriteLine("1. Square.");
            Console.WriteLine("2. Rectangle.");
            Console.WriteLine("3. Triangle.");
            Console.WriteLine("4. Circle.");
            Console.WriteLine("5. Exit.");
            Console.Write("Enter choice between(1 - 5): ");
            if (!int.TryParse(Console.ReadLine(), out shapechoice) || shapechoice < 1|| shapechoice > 5)
            {Console.WriteLine("Invalid Input. Please Enter a Number between 1 anf 5!");}
            
        } while (shapechoice > 5 || shapechoice < 1);
        if (shapechoice  == 5)
        {
            Console.WriteLine("Program Ended!");
            return;
        }
        int operationchoice;
        do
        {
            Console.WriteLine("\nWhich operation do you want to perform?");
            Console.WriteLine("1. Area");
            Console.WriteLine("2. Perimeter");
            Console.Write("Enter your choice (1 - 2): ");
            if (int.TryParse(Console.ReadLine(), out operationchoice) && operationchoice >= 1 && operationchoice <= 2)
            {
                break;
            }
            Console.WriteLine("Invalid Choice. Please enter 1 or 2!");
            operationchoice = 0;
        } while (operationchoice == 0);
        CalculateValue(shapechoice, operationchoice);
    }
    public void CalculateValue(int shape, int calculation)
    {
        switch (shape)
        {
            case 1:
               length = GetValidDouble("Enter the length for the square: ");
               if (calculation == 1)
               Console.WriteLine($"Area of square: {length * length}");
               else Console.WriteLine($"Perimeter of square: {4 * length}");
               break;                
            case 2:
               length = GetValidDouble("Enter the length for the rectangle: ");
               height = GetValidDouble("Enter the Height for the rectangle: ");
               if (calculation == 1)
               Console.WriteLine($"Area of rectangle: {length * height}");
               else Console.WriteLine($"Perimeter of rectangle: {2 * ( length + height)}");
               break; 
            case 3:
                length = GetValidDouble("Enter the length for the triangle: ");
                height = GetValidDouble("Enter the height for the triangle: ");
                if (calculation == 1) Console.WriteLine($"The area of a triangle is : { 0.5 * (length * height)}");
                else  
                {
                    double hypo = Math.Sqrt((height * height ) + (length * length));
                    Console.WriteLine($"The Perimeter of triangle is : {height + length + hypo}");
                }
                break;
            case 4:
                radius = GetValidDouble("Enter the radius for the circle: ");
                if (calculation == 1)
                {
                    Console.WriteLine($"The area of the circle is: {Math.PI * radius * radius}");
                }
                else
                {
                    Console.WriteLine($"The perimeter of aa circle is: {Math.PI * 2 * radius}");
                }
                break;
        }
    }
}
class Program
{
    public static void Main(string[] args)
    {
        GetValue objvalue = new GetValue();
        objvalue.GetData();
    }
}