using System;
using System.Runtime.InteropServices.Swift;
namespace TemperatureConverter
{
    class UserInput
    {
        double inputTemperature;
        char inputScale;
        public UserInput()
        {
            Console.WriteLine("--- Temperature Converter ---\n");
        }
        public void GetTemperature()
        {
            while (true){
            Console.Write("Enter the temperature: ");
            if (double.TryParse(Console.ReadLine(),out inputTemperature))
            {
                break;
            }
            Console.WriteLine("Invalid Input! Please Enter a valid number.");
            }
            
            while (true)
            {
                Console.Write("Enter Current scale unit(C for Celsius, F for Fahrenheit, K for Kelvin): ");
               string input = Console.ReadLine()?.Trim().ToUpper() ??"";
                if (input.Length == 1 && (input[0] == 'C' || input[0] == 'F' || input[0] == 'K'))
                {
                    inputScale = input[0];
                    break;
                }
                Console.WriteLine("Invalid Scale! Please Enter C, F, or K.");
            }
        }
        public void Display()
        {
            Console.WriteLine($"\n--- Conversion result for {inputTemperature}°{inputScale} ---");
            switch (inputScale)
            {
                case 'C':
                double C2F = (inputTemperature * 9 / 5) + 32;
                double C2K = (inputTemperature + 273.15);
                Console.WriteLine($"Ferenheit    :{C2F:f2} F");
                Console.WriteLine($"Kelvin       :{C2K:f2} K");
                break;
                case 'K':
                double K2F = (inputTemperature - 273.15) * 9 / 5 + 32;
                double K2C = inputTemperature - 273.15;
                Console.WriteLine($"Celcious      :{K2C:f2}C");
                Console.WriteLine($"Ferenhite     :{K2F:f2}F");
                break;
                case 'F':
                double F2K = (inputTemperature - 32) * 5 / 9 + 273.15;
                double F2C = (inputTemperature - 32) * 5 / 9;
                Console.WriteLine($"Celcious     :{F2C:f2}C");
                Console.WriteLine($"Kelvin       :{F2K:f2} K");
                break;
                    
            }
        }
    }
    class Program
    {
        public static void Main()
        {
            UserInput user = new UserInput();
            user.GetTemperature();
            user.Display();
        }
    }
}