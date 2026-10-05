using System;
namespace Birthyear
{
    class UserInput
    {
        string? fullname;
        DateOnly birthdate;
        readonly DateOnly CurrentDate = DateOnly.FromDateTime(DateTime.Now);

        public UserInput()
        {
            Console.WriteLine("Calculate your birth year from Date of Birth.");
        }

        public void GetInput()
        {
            do
            {
                Console.Write("Enter your fullname: ");
                fullname = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(fullname))
                    Console.WriteLine("Please enter a valid Name!");
            } while (string.IsNullOrWhiteSpace(fullname));

            while (true)
            {
                Console.Write("Enter your birthdate (yyyy-MM-dd): ");
                if (!DateOnly.TryParseExact(Console.ReadLine(), "yyyy-MM-dd", out birthdate))
                    Console.WriteLine("Invalid date format!");
                else if (birthdate > CurrentDate)
                    Console.WriteLine("Birthdate can't be in the future!");
                else
                    break;
            }
        }

        public (int BirthYear, int Years, int Months, int Days) Calculate()
        {
            int years = CurrentDate.Year - birthdate.Year;
            if (birthdate.AddYears(years) > CurrentDate)
                years--;

            DateOnly lastBirthday = birthdate.AddYears(years);
            int months = 0;
            while (lastBirthday.AddMonths(months + 1) <= CurrentDate)
                months++;

            int days = CurrentDate.DayNumber - birthdate.DayNumber;
            return (birthdate.Year, years, months, days);
        }

        public void ShowResult()
        {
            var (birthYear, years, months, days) = Calculate();
            Console.WriteLine($"Name: {fullname}");
            Console.WriteLine($"Birth year: {birthYear}");
            Console.WriteLine($"Age: {years} years, {months} months");
            Console.WriteLine($"Days old: {days}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            UserInput user = new UserInput();
            user.GetInput();
            user.ShowResult();
        }
    }
}