namespace _02.Division;

class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int divisibleNumber = 0;
        if (number % 2 == 0)
        {
            divisibleNumber = 2;
            if (number % 3 == 0)
            {
                divisibleNumber = 6;
            }
            if (number % 10 == 0)
            {
                divisibleNumber = 10;
            }

           
        }
        else if (number % 3 == 0)
        {
            divisibleNumber = 3;
            if (number % 7 == 0)
            {
                divisibleNumber = 7;
            }
        }
        else if (number % 7 == 0)
        {
            divisibleNumber = 7;
        }
        else
        {
            Console.WriteLine("Not divisible");
            return;
        }

        Console.WriteLine($"The number is divisible by {divisibleNumber}");
        
    }
}