namespace _05.Login;

class Program
{
    static void Main(string[] args)
    {
        string username = Console.ReadLine();

        string password = "";
        for (int i = username.Length - 1; i >= 0; i--)
        {
            password += username[i];
        }

        string passwordInput = Console.ReadLine();
        int countOfAttempts = 0;
        while (passwordInput != password)
        {
            countOfAttempts++;
            if (countOfAttempts == 4)
            {
                Console.WriteLine($"User {username} blocked!");
                return;
            }

            Console.WriteLine("Incorrect password. Try again.");

            passwordInput = Console.ReadLine();
        }

        Console.WriteLine($"User {username} logged in.");
    }
}