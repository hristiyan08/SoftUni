﻿namespace _04.BackIn30Minutes;

class Program
{
    static void Main(string[] args)
    {
        int hours = int.Parse(Console.ReadLine()!);
        int minutes = int.Parse(Console.ReadLine()!);
        minutes += 30;
        if (minutes >= 60)
        {
            minutes -= 60;
            hours++;
            if (hours >= 24)
            {
                hours -= 24;
            }
        }


        Console.WriteLine(minutes / 10 == 0 ? $"{hours}:0{minutes}" : $"{hours}:{minutes}");
    }
}