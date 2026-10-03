using System;
using System.Xml.Serialization;

namespace Calculator
{
    class MiniCalculator
    {
        int input1, input2;
        int result;
        int choice;
        public MiniCalculator()
        {
            Console.WriteLine("-----  CALCULATOR  -----");
            Console.WriteLine();
        }        
        public void ShowMenu()
        {   // Menu 
            Console.WriteLine("Select operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5 Exit (any numberrather then 1 to 4 )");
        }
        public void UserChoice()
        {
            Console.Write("Enter choice (1-5): ");
            string? rawInput = Console.ReadLine();

            // int.TryParse checks if rawInput is a number. 
            // If it is a number, it saves it in 'choice'. If it isn't, it outputs 0.
            if (!int.TryParse(rawInput, out choice))
            {
                choice = 0; // Set choice to 0 to safely trigger the default case in Display()
            }
        }
        public int GetChoice()
        {
            return choice;
        }
        public void GetInput(){
            // First input
            Console.Write("Enter First number: ");
            input1 = Convert.ToInt32(Console.ReadLine());
            // Second input
            Console.Write("Enter Second number: ");
            input2 = Convert.ToInt32(Console.ReadLine());
        }
        public int addition()  //declearing the operations
        {
            result = input1 + input2;
            return result;
        }
        public int subtraction()
        {
            result = input1 - input2;
            return result;
        }
        public int multiplication()
        {
            result = input1 * input2;
            return result;
        }
        public double division()
        {
            return (double) input1 / input2;
        }
        public void Display()  // To display the output.
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"The Total of two number: {input1} + {input2} = {addition()} ");
                    break;
                case 2:
                    Console.WriteLine($"The Difference between two number: {input1} - {input2} = {subtraction()} ");
                    break;
                case 3:
                    Console.WriteLine($"The Product of two number: {input1} * {input2} = {multiplication()} ");
                    break;
                case 4:
                  if (input2 == 0)
                    {
                        Console.WriteLine("Cannot divide by 0!");
                    }
                  else
                    {
                        Console.WriteLine($"The Dividion of two number: {input1} / {input2} = {division()} ");
                    }
                  break;
                default:
                    Console.WriteLine("Program Ended!");
                    break;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MiniCalculator c1 = new MiniCalculator();
            int userchoice;
            do
            {
                c1.ShowMenu();
                c1.UserChoice();
                userchoice = c1.GetChoice();
                if(userchoice >=1 && userchoice <= 4)
                {
                   c1.GetInput(); 
                }
                
                c1.Display();
                if (userchoice !=5){
                    Console.WriteLine("------------------------------------------------");
                }
            }while(userchoice >= 1 && userchoice <= 4); // Continues the loop for this condition else ended.
        }
    }
}