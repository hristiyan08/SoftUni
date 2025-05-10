namespace _10.RageExpenses;

class Program
{
    static void Main(string[] args)
    {
        int countOfLostGames = int.Parse(Console.ReadLine());
        double headsetPrice = double.Parse(Console.ReadLine());
        double mousePrice = double.Parse(Console.ReadLine());
        double keyboardPrice = double.Parse(Console.ReadLine());
        double displayPrice = double.Parse(Console.ReadLine());

        int countOfHeadsetTrashing = 0;
        int countOfMouseTrashing = 0;
        int countOfKeyboardTrashing = 0;
        int countOfDisplayTrashing = 0;

        for (int i = 1; i <= countOfLostGames; i++)
        {
            if (i % 12 == 0)
            {
                countOfDisplayTrashing++;
            }

            if (i % 6 == 0)
            {
                countOfKeyboardTrashing++;
            }

            if (i % 3 == 0)
            {
                countOfMouseTrashing++;
            }

            if (i % 2 == 0)
            {
                countOfHeadsetTrashing++;
            }
        }

        double totalPrice = headsetPrice * countOfHeadsetTrashing + mousePrice * countOfMouseTrashing +
                            keyboardPrice * countOfKeyboardTrashing + countOfDisplayTrashing * displayPrice;
        Console.WriteLine($"Rage expenses: {totalPrice:f2} lv.");
    }
}