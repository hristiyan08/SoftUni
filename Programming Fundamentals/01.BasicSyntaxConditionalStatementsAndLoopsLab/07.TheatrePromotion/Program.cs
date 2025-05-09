namespace _07.TheatrePromotion;

class Program
{
    static void Main(string[] args)
    {
        string day = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        
        int price = 0;
        if (age >= 0 && age <= 18)
        {
            if (day == "Weekday")
            {
                price = 12; 
            }
            else if (day == "Weekend")
            {
                price = 15;
            }
            else
            {
                price = 5;
            }
        }
        else if (age <= 64)
        {
            if (day == "Weekday")
            {
                price = 18; 
            }
            else if (day == "Weekend")
            {
                price = 20;
            }
            else
            {
                price = 12;
            } 
        }
        else if (age <= 122)
        {
            if (day == "Weekday")
            {
                price = 12; 
            }
            else if (day == "Weekend")
            {
                price = 15;
            }
            else
            {
                price = 10;
            }
        }
        

        Console.WriteLine(age < 0 || age > 122 ? "Error!" : $"{price}$");
    }
}