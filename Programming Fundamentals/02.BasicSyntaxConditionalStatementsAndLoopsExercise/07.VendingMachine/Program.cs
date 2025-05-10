namespace _07.VendingMachine;

class Program
{
    static void Main(string[] args)
    {
        string input = "";
        double balance = 0;
        while ((input = Console.ReadLine()) != "Start")
        {
            double coins = double.Parse(input);
            switch (coins)
            {
                case 0.1:
                    balance += 0.1;
                    break;
                case 0.2:
                    balance += 0.2;
                    break;
                case 0.5:
                    balance += 0.5;
                    break;
                case 1:
                    balance += 1;
                    break;
                case 2:
                    balance += 2;
                    break;
                default:
                    Console.WriteLine($"Cannot accept {coins}");
                    break;
            }
        }

        while ((input = Console.ReadLine()!) != "End")
        {
            if (input == "Nuts")
            {
                if (balance >= 2.0)
                {
                    Console.WriteLine("Purchased nuts");
                    balance -= 2.0;
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
            }
            else if (input == "Water")
            {
                if (balance >= 0.7)
                {
                    Console.WriteLine("Purchased water");
                    balance -= 0.7;
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
            }
            else if (input == "Crisps")
            {
                if (balance >= 1.5)
                {
                    Console.WriteLine("Purchased crisps");
                    balance -= 1.5;
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
            }
            else if (input == "Soda")
            {
                if (balance >= 0.8)
                {
                    Console.WriteLine("Purchased soda");
                    balance -= 0.8;
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
            }
            else if (input == "Coke")
            {
                if (balance >= 1.0)
                {
                    Console.WriteLine("Purchased coke");
                    balance -= 1;
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
            }
            else
            {
                Console.WriteLine("Invalid product");
            }
        }

        Console.WriteLine($"Change: {balance:F2}");
    }
}