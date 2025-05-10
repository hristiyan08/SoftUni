namespace _06.StrongNumber;

class Program
{
    static void Main(string[] args)
    {
      int number = int.Parse(Console.ReadLine());
      int sumOfFactiorielsOfEachDigit = 0;
      
      int eachDigits = number;
      while (eachDigits > 0)
      {
          int currentDigit = eachDigits % 10;
          int factorial = 1;
          for (int i = 1; i <= currentDigit; i++)
          {
              factorial *= i;
          }

          sumOfFactiorielsOfEachDigit += factorial;
          eachDigits /= 10;
      }

      Console.WriteLine(sumOfFactiorielsOfEachDigit == number ? "yes" : "no");
    }

}