using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("- - - - - - - - - - - - - - - - ");
        Console.WriteLine("   Bruno's distance converter   ");
        Console.WriteLine("- - - - - - - - - - - - - - - - ");
        
        Console.WriteLine("Please enter the numerical amount : ");
        double value = double.Parse(Console.ReadLine());

        Console.WriteLine("Please assign the measurement unit for the inputted number :");
        Console.WriteLine("1. Miles");
        Console.WriteLine("2. Feet");
        Console.WriteLine("3. Meters");

        int unit = int.Parse(Console.ReadLine());

        switch (unit)
        {
            case 1:
                Console.WriteLine("{0} miles", value);
                break;
            case 2:
                Console.WriteLine("{0} feet", value);
                break;
            case 3:
                Console.WriteLine("{0} meters", value);
                break;
            default:
                Console.WriteLine("Invalid selection.");
                break;
        }
        
        Console.WriteLine("- - - - - - - - - - - - - - - - ");
        Console.ReadLine();
    }
}
