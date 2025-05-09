namespace _02.Passed;

class Program
{
    static void Main(string[] args)
    {
        double grade = double.Parse(Console.ReadLine());
        Console.WriteLine(grade >= 3.00 ? "Passed!" : "");
    }
}