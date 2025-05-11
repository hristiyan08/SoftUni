using System.Numerics;

namespace _04.CenturiesToMinutes;

class Program
{
    static void Main(string[] args)
    {
       sbyte centuries = sbyte.Parse(Console.ReadLine());
       int years = centuries * 100;
       BigInteger days = (BigInteger)(years * 365.2422);
       BigInteger hours = days * 24;
       BigInteger minutes = hours * 60;
       Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
    }
}