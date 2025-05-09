namespace _09.SumOfOddNumbers;

class Program
{
    static void Main(string[] args)
    {
        int countOfOddNumbers = int.Parse(Console.ReadLine());
        int sumOfOddNumbers = 0;
        int num = 1;
        for (int i = 1; i <= countOfOddNumbers; i++)
        {
            
            Console.WriteLine(num);
            sumOfOddNumbers += num;
            num+=2;
            
        }

        Console.WriteLine($"Sum: {sumOfOddNumbers}");
    }
}