namespace _01.StudentInformation;

class Program
{
    static void Main(string[] args)
    {
        string studentName = Console.ReadLine()!;
        byte studentAge = byte.Parse(Console.ReadLine()!);
        double studentGrade = double.Parse(Console.ReadLine()!);
        Console.WriteLine($"Name: {studentName}, Age: {studentAge}, Grade: {studentGrade:F2}");
    }
}