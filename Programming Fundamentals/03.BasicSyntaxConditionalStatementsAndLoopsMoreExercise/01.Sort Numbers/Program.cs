﻿namespace _01.Sort_Numbers;

class Program
{
    static void Main(string[] args)
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());

        if (firstNumber >= secondNumber && firstNumber >= thirdNumber)
        {
            Console.WriteLine(firstNumber);
            if (secondNumber >= thirdNumber)
            {
                Console.WriteLine(secondNumber);
                Console.WriteLine(thirdNumber);
            }
            else
            {
                Console.WriteLine(thirdNumber);
                Console.WriteLine(secondNumber);
            }
        }

        if (secondNumber >= firstNumber && secondNumber >= thirdNumber)
        {
            Console.WriteLine(secondNumber);
            if (firstNumber >= thirdNumber)
            {
                Console.WriteLine(firstNumber);
                Console.WriteLine(thirdNumber);
            }
            else
            {
                Console.WriteLine(thirdNumber);
                Console.WriteLine(firstNumber);
            }
        }
        if (thirdNumber >= firstNumber && thirdNumber >= secondNumber)
        {
            Console.WriteLine(thirdNumber);
            if (firstNumber >= secondNumber)
            {
                Console.WriteLine(firstNumber);
                Console.WriteLine(secondNumber);
            }
            else
            {
                Console.WriteLine(secondNumber);
                Console.WriteLine(firstNumber);
            }
        }
    }
}