

class Program
{
    static void Main(string[] args)
    {
        int countOfNumber = int.Parse(Console.ReadLine());
        
        for (int i = 1; i <= countOfNumber; i++)
        {
            int eachDigit = i;
            int sumOfEachDigit = 0;
            while (eachDigit > 0)
            {
                sumOfEachDigit += eachDigit % 10;
                eachDigit = eachDigit / 10;
            }

            bool isSpecial = (sumOfEachDigit == 5) || (sumOfEachDigit == 7) || (sumOfEachDigit == 11);
            Console.WriteLine("{0} -> {1}", i, isSpecial);
        }
    }
}