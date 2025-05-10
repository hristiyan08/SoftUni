namespace _11.Orders;

class Program
{
    static void Main(string[] args)
    {
        int countOfOrders = int.Parse(Console.ReadLine());
        double totalPrice = 0;
        for (int i = 1; i <= countOfOrders; i++)
        {
            double pricePerCapsule = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int countOfCapsules = int.Parse(Console.ReadLine());

            double priceOfCoffe = ((days * countOfCapsules) * pricePerCapsule);
            totalPrice += priceOfCoffe;
            Console.WriteLine($"The price for the coffee is: ${priceOfCoffe:f2}");
        }

        Console.WriteLine($"Total: ${totalPrice:f2}");
    }
}