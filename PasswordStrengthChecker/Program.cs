using System;
class UserPassword
{
    public string? password;
    public string? username;
    public void GetPassword()
    {
        while (true)
        {
            Console.Write("Enter your username: ");
            username = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(username))
            {
                break; // exit from the loop
            }
            Console.WriteLine("Username cannot be empty!");
        }
        while (true)
        {
            Console.Write("Enter your password: ");
            password = Console.ReadLine() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(password))
            {
                Console.WriteLine("Password required!");
                
            }
            else if (password.Length <= 7)
            {
                Console.WriteLine("Password should contain minimum 8 characters!");
            }
            else
            {
                return; // exit from the loop
            }
            
        }

    }
    public void CheckPassword()
    {
        int uppercount = 0;
        int lowercount = 0;
        int digitcount = 0;
        int symbolcount = 0;

        foreach (char ch in password ?? string.Empty)
        {
            if (char.IsUpper(ch))
            {
                uppercount++;
            }
            else if(char.IsLower(ch))
            {
                lowercount++;
            }
            else if (char.IsDigit(ch))
            {
                digitcount++;
            }
            else if (!char.IsLetterOrDigit(ch))
            {
                symbolcount++;
            }
        }
        if (uppercount >=1 && lowercount >=1 && digitcount >= 1 && symbolcount >= 1)
        {
            Console.WriteLine("Very Strong!");
        }
        else if(uppercount >=1 && lowercount >=1 || digitcount >= 1 && symbolcount >= 1)
        {
            Console.WriteLine("Strong!");
        }
        else if(uppercount >=1 || lowercount >=1 || digitcount >= 1 || symbolcount >= 1)
        {
            Console.WriteLine("Weak!");
        }
        else
        {
            Console.WriteLine("Plese create a strong password");
        }

        int totalvariety = 0;
        if (uppercount >= 1) totalvariety++;
        if(lowercount >= 1) totalvariety++;
        if(digitcount >= 1) totalvariety++;
        if(symbolcount >= 1) totalvariety++;
        
        string rating ;
        switch (totalvariety)
        {
            case 4:
            rating = "Very Strong!";
            break;
            case 3:
            case 2:
            rating = "Strong!";
            break;
            default :
            rating = "Weak!";
            break;
        }
        DisplayPasswordDetails(uppercount,lowercount,digitcount,symbolcount,totalvariety,rating);
    }
     public void DisplayPasswordDetails(int upper, int lower, int digit, int symbol, int totalCategories, string strengthRating)
    {
        Console.WriteLine($"\nHello, {username}!");
        Console.WriteLine("--- Password Analysis ---");
        Console.WriteLine($"- Uppercase letters: {upper}");
        Console.WriteLine($"- Lowercase letters: {lower}");
        Console.WriteLine($"- Numbers: {digit}");
        Console.WriteLine($"- Symbols: {symbol}");
        Console.WriteLine($"Total Character Categories Used: {totalCategories} / 4");
        Console.WriteLine($"Final Strength Rating: {strengthRating}");
    }

}
class Program
{
    public static void Main(string[] args)
    {
        UserPassword objpass = new UserPassword();
        objpass.GetPassword();
        objpass.CheckPassword();
    }
}