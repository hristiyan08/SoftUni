namespace _03.Vacation;

class Program
{
    static void Main(string[] args)
    {
        int countOfPeople = int.Parse(Console.ReadLine());
        string typeOfGroup = Console.ReadLine();
        string day = Console.ReadLine();

        double pricePerPerson = 0;
        double totalPrice = 0;
        if (day == "Friday")
        {
            if (typeOfGroup == "Students")
            {
                pricePerPerson = 8.45; 
            }
            else if (typeOfGroup == "Business")
            {
                pricePerPerson = 10.90;
            }
            else
            {
                pricePerPerson = 15;
            }
        }
        else if (day == "Saturday")
        {
            if (typeOfGroup == "Students")
            {
                pricePerPerson = 9.80;
            }
            else if (typeOfGroup == "Business")
            {
                pricePerPerson = 15.60;
            }
            else
            {
                pricePerPerson = 20;
            }
            
        }
        else
        {
            if (typeOfGroup == "Students")
            {
                pricePerPerson = 10.46;
            }
            else if (typeOfGroup == "Business")
            {
                pricePerPerson = 16;
            }
            else
            {
                pricePerPerson = 22.50;
            }
        }
        
        totalPrice = countOfPeople * pricePerPerson;
        if (typeOfGroup == "Students" && countOfPeople >= 30)
        {
            totalPrice *= 0.85;
        }
        else if (typeOfGroup == "Business" && countOfPeople >= 100)
        {
            totalPrice -= pricePerPerson*10;
        }
        else if (typeOfGroup == "Regular" && (countOfPeople >= 10 && countOfPeople <= 20))
        {
            totalPrice *= 0.95;
        }

        Console.WriteLine($"Total price: {totalPrice:F2}" );
    }
}