namespace _05.Messages;

class Program
{
    static void Main(string[] args)
    {
        int countOfWords = int.Parse(Console.ReadLine());
        string word = "";
        for (int i = 1; i <= countOfWords; i++)
        {
            int number = int.Parse(Console.ReadLine());
            int countOfDigits = 0;
            int mainDigit = number % 10;
            while (number > 0)
            {
                countOfDigits++;
                number /= 10;
            }

            int offset = (mainDigit - 2) * 3;
            if (mainDigit == 8 || mainDigit == 9)
            {
                offset++;
            }

            int letterIndex = offset + countOfDigits - 1 + 97;
            if (letterIndex == 90)
            {
                word += " ";
            }
            else
            {
                word += (char)letterIndex;
            }
        }

        Console.WriteLine(word);
    }
}