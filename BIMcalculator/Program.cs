using System;
class BMICalculator
{
   private double height;
   private double weight;
   private int choice;
    public BMICalculator()
    {
        Console.WriteLine("--- BMI Calculator ---");
    }
    public void getInput()
    {
        while (choice < 1 || choice > 4)
        {
            Console.WriteLine("\nSelect your exact unit Configration:");
            Console.WriteLine("1. Meters (m) and Kilograms (kg)");
            Console.WriteLine("2. Centimeters (cm) and Kilograms (kg)");
            Console.WriteLine("3. Feet (ft, decimal) and Pounds (lbs)");
            Console.WriteLine("4. Inches (in) and Pounds (lbs)");
            Console.Write("Enter choice (1-4): ");
            int.TryParse(Console.ReadLine(), out choice);
        }

        string heightPrompt = "";
        string weightPrompt = "";

        switch (choice)
        {
            case 1 :
                heightPrompt = "meters (e.g., 1.75)";
                weightPrompt = "kilograms (e.g., 70)";
                break;
            case 2:
                heightPrompt = "centimeters (e.g., 175)";
                weightPrompt = "kilograms (e.g., 70)";
                break;
            case 3:
                heightPrompt = "feet in decimal (e.g., 5.75)";
                weightPrompt = "pounds (e.g., 154)";
                break;
            case 4:
                heightPrompt = "inches (e.g., 69)";
                weightPrompt = "pounds (e.g., 154)";
                break;
        }
        while (true)
        {
            Console.Write($"Enter your height in {heightPrompt}: ");
            if (double.TryParse(Console.ReadLine(), out height) && height > 0 )break;
            Console.WriteLine("Invalid Input. Try again!");
        }
        while (true)
        {
            Console.Write($"Enter your Weight in {weightPrompt}: ");
            if (double.TryParse(Console.ReadLine(), out weight) && weight > 0)break;
           Console.WriteLine("Invalid Input. Try again!");
        }
    }
    public void calculate()
    {
       double bmi = 0;
       switch (choice)
        {
            case 1:
                bmi = weight / (height * height);
                break;
            case 2:
                bmi = weight / (height * height) * 10000;
                break;
            case 3:
                bmi = weight / (height * height) * 4.88243;
                break;
            case 4:
                bmi = weight / (height * height) *703;
                break;
        }
        Console.WriteLine("\n=============================");
        Console.WriteLine($"Calculate BMI value: {bmi:F2}");
        Console.WriteLine("============================");
        Classification(bmi);
    }
    public void Classification(double bmi)
    {
        Console.WriteLine("\nWHO Global Standard Status:");
        if (bmi < 18.5) Console.WriteLine("Status: UnderWeight");
        else if(bmi < 25.0) Console.WriteLine("Status: Normal Weight");
        else if(bmi < 30.0) Console.WriteLine("Status: OverWeight");
        else Console.WriteLine("Status: Obese");

        Console.WriteLine("\nRevised asian / Indian Status");
        if (bmi < 18.5) Console.WriteLine("Status: UnderWeight");
        else if(bmi < 23.0) Console.WriteLine("Status: Normal Weight");
        else if(bmi < 25.0) Console.WriteLine("Status: OverWeight(Increased Risk)");
        else Console.WriteLine("Status: Obese (High Risk)");
         Console.WriteLine("============================");
    }
}
class Program
{
    static void Main(string[] args){
    BMICalculator myobj = new BMICalculator();
    myobj.getInput();
    myobj.calculate();
}}
