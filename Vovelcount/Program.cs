using System;
class Base
{
    string input = string.Empty;
    int countvovel = 0;
    int counta = 0;
        int counte = 0;
        int counti = 0;
        int counto = 0;
        int countu = 0;
        int countconsonent = 0;
    public Base()
    {
        Console.WriteLine(" - - - - - - - - - - - - - - -");
        Console.WriteLine(" - - - - Count Vovel - - - - -");
        Console.WriteLine(" - - - - - - - - - - - - - - -\n");
    }
    public void GetInput()
    {while (true){
        Console.Write("Enter your string: ");
        input = Console.ReadLine() ?? string.Empty;
        if (!string.IsNullOrWhiteSpace(input))
            {
                return;
            }
        }
    }
    public void CalculateVovelCount()
    {
        
        foreach (char c in input)
        {
            switch (char.ToLower(c))
            {
                case 'a':
                    counta ++;
                    countvovel ++;
                    break;
                case 'e':
                 counte ++;
                    countvovel ++;
                    break;
                case 'i':
                 counti ++;
                    countvovel ++;
                    break;
                case 'o':
                 counto ++;
                    countvovel ++;
                    break;
                case 'u':
                     countu ++;
                    countvovel ++;
                    break;
                default:
                    countconsonent ++;
                    break;
            }
        }
    }
    public void display()
    {
        Console.WriteLine($"There are {countvovel} vovels in a string.\n");
        Console.WriteLine($"There are {countconsonent} in a string.");
         Console.WriteLine("-----------------------------");
        Console.WriteLine($"Individual Vowel Breakdown:");
        Console.WriteLine($"A: {counta}");
        Console.WriteLine($"E: {counte}");
        Console.WriteLine($"I: {counti}");
        Console.WriteLine($"O: {counto}");
        Console.WriteLine($"U: {countu}");
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Base bobject = new Base();
        bobject.GetInput();
        bobject.CalculateVovelCount();
        bobject.display();
    }
}