class Factorial
{
    int userinput;
    long factorial = 1;
    public void GetInput()
    {
        while (true)
        {
            Console.Write("Enter The number with in (1-20) ");
            if (int.TryParse(Console.ReadLine(), out userinput) && userinput > 0 && userinput <= 20)
            {
                return ;
            }
            Console.WriteLine("Oops! something went Wrong.");
        }
    }
    public void Run()
    {
        for (int i = 1; i <= userinput; i++)
        {
           factorial *=i; 
        }    
        Console.WriteLine($"The factorial of {userinput} is {factorial}");
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Factorial fact = new Factorial();
        fact.GetInput();
        fact.Run();
    }
}