namespace _02.PoundsToDollars;

class Program
{
    static void Main(string[] args)
    {
        double britishPounds = double.Parse(Console.ReadLine());
        double dollars = britishPounds * 1.31;
        Console.WriteLine($"{dollars:F3}");
    }
}