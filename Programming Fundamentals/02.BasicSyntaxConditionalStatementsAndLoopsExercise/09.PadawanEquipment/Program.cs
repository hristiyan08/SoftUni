namespace _09.PadawanEquipment;

class Program
{
    static void Main(string[] args)
    {
        double ammountOfMoney = double.Parse(Console.ReadLine());
        int countOfStudents = int.Parse(Console.ReadLine());
        double priceOfEachLightsaber = double.Parse(Console.ReadLine());
        double priceOfEachRobe = double.Parse(Console.ReadLine());
        double priceOfEachBelt = double.Parse(Console.ReadLine());

       
        double priceOfSabers = priceOfEachLightsaber * (countOfStudents + Math.Ceiling(countOfStudents * 0.10));
        double priceOfRobes = priceOfEachRobe * countOfStudents;
        double priceOfBelts = 0;
        int countOfFreeBelts = 0;
        for (int i = 1; i <= countOfStudents; i++)
        {
            if (i % 6 == 0)
            {
                countOfFreeBelts ++;
            }
        }
        priceOfBelts = priceOfEachBelt * (countOfStudents - countOfFreeBelts);
        double totalPrice = priceOfBelts + priceOfRobes + priceOfSabers;

        if (ammountOfMoney >= totalPrice)
        {
            Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
        }
        else
        {
            Console.WriteLine($"John will need {totalPrice-ammountOfMoney:F2}lv more.");
        }
    }
}