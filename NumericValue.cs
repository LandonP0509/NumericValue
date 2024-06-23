using System

class Program
{
    static void Main()
    {
        Console.Write("Please enter the length of your rectangle: ");
        double length = Convert.ToDouble(Console.ReadLine());

        console.Write("Please enter the width of your rectangle: ");
        double width = Convert.ToDouble(console.ReadLine());

        double rArea = length * width;

        Console.WriteLine("The area of your rectangle is " + rArea);
    }
}
