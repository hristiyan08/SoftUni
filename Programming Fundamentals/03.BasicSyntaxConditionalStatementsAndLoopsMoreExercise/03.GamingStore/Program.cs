namespace _03.GamingStore;

class Program
{
    static void Main(string[] args)
    {
        double balance = double.Parse(Console.ReadLine());
        double currentBalance = balance;
        string input = "";
        double gameBalance  = 0;
        string gameName = "";
        while ((input = Console.ReadLine()) != "Game Time")
        {
            
            switch (input)
            {
                case "OutFall 4":
                    gameBalance = 39.99;
                    gameName = "OutFall 4";
                    break;
                case "CS: OG":
                    gameBalance = 15.99;
                    gameName = "CS: OG";
                    break;
                case "Zplinter Zell":
                    gameBalance = 19.99;
                    gameName = "Zplinter Zell";
                    break;
                case "Honored 2":
                    gameBalance = 59.99;
                    gameName = "Honored 2";
                    break;
                case "RoverWatch":
                    gameBalance = 29.99;
                    gameName = "RoverWatch";
                    break;
                case "RoverWatch Origins Edition":
                    gameBalance = 39.99;
                    gameName = "RoverWatch Origins Edition";
                    break;
                default:
                    Console.WriteLine("Not Found");
                    continue;
            }

            if (currentBalance >= gameBalance)
            {
                currentBalance -= gameBalance;
                Console.WriteLine($"Bought {gameName}");
            }
            else
            {
                Console.WriteLine("Too Expensive");
            }
            if (currentBalance == 0.00)
            {
                Console.WriteLine("Out of money!");
                return;
            }
        }

        Console.WriteLine($"Total spent: ${balance-currentBalance:F2}. Remaining: ${currentBalance:F2}");
    }
}