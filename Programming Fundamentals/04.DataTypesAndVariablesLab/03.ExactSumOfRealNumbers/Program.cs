﻿namespace _03.ExactSumOfRealNumbers;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        decimal sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += decimal.Parse(Console.ReadLine());
        }

        Console.WriteLine(sum);
         
    }
}