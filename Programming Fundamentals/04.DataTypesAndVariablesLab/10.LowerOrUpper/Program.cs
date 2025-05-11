namespace _10.LowerOrUpper;

class Program
{
    static void Main(string[] args)
    {
        bool isLowerCase = Char.IsLower(Char.Parse(Console.ReadLine()!));
        Console.WriteLine(isLowerCase ? "lower-case" : "upper-case" );
    }
}