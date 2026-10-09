class Program
{
    public static void Main(string[] args)
    {
        string username;
        while (true)
        {
        Console.Write("Enter your name: ");
        username = Console.ReadLine() ?? string.Empty;
        if (string.IsNullOrWhiteSpace(username))
        {
            Console.WriteLine("Your string cannot be empty, spaces or tabs!");
        }
            else
            {
                break;
            }
    }
        Console.WriteLine($"Hello {username} Welcome to C#!");
    }
}