// • Computer picks a random number 1 to 100.
using System;
namespace guessthenumber
{
    class GuessNumber
    {
        private readonly Random random = new Random();
        private readonly int computernumber;
        int ChanceCount ;
        int usernumber;
        public GuessNumber()
        {
            Console.WriteLine("---- Guess the Number ----");
            computernumber = random.Next(1, 101);
        } 
        // • Player has 7 tries, told "higher" or "lower" after each guess.
        public void GetInput()
        {
            Console.Write("Enter your number: ");
            if(int.TryParse(Console.ReadLine(), out usernumber))
            {
                
            }
            
        }
        public void Play()
        {
            for (ChanceCount = 0; ChanceCount < 7; ChanceCount++)
            {
                GetInput();

                if (usernumber == computernumber)
                {
                    Console.WriteLine($"You won Number is: {computernumber}");
                    return;
                }
                else if (usernumber < computernumber)
                {
                    Console.WriteLine("Higher!");
                }
                else
                {
                    Console.WriteLine("Lower!");
                }
            }
            Console.WriteLine($"Game overthe Correct number was{computernumber}");
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            GuessNumber gn1 = new GuessNumber();
            gn1.Play();
        }
    }
}