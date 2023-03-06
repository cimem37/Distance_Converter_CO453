using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("- - - - - - - - - - - - - - - - ");
        Console.WriteLine("   Bruno's distance converter   ");
        Console.WriteLine("- - - - - - - - - - - - - - - - ");

        Console.WriteLine("Please enter the numerical total to procceed");
        double value;
        while (!double.TryParse(Console.ReadLine(), out value))
        {
            Console.WriteLine("Invalid input. Please enter a numerical value:");
        }

        Console.WriteLine("Please assign the measurement unit for the inputted number");
        Console.WriteLine("1. Miles");
        Console.WriteLine("2. Feet");
        Console.WriteLine("3. Meters");

        int unit;
        while (!int.TryParse(Console.ReadLine(), out unit) || unit < 1 || unit > 3)
        {
            Console.WriteLine("Invalid selection. Please enter 1, 2, or 3:");
        }

        string unit1 = "", unit2 = "";
        double value1 = 0, value2 = 0;

        switch (unit)
        {
            case 1:
                unit1 = "feet";
                unit2 = "meters";
                value1 = value * 5280;
                value2 = value * 1609.34;
                Console.WriteLine("{0} miles", value);
                break;
            case 2:
                unit1 = "miles";
                unit2 = "meters";
                value1 = value / 5280;
                value2 = value / 3.28084;
                Console.WriteLine("{0} feet", value);
                break;
            case 3:
                unit1 = "miles";
                unit2 = "feet";
                value1 = value / 1609.34;
                value2 = value * 3.28084;
                Console.WriteLine("{0} meters", value);
                break;
        }

        Console.WriteLine("Select the unit of measurement to convert to:");
        Console.WriteLine("1. {0}", unit1);
        Console.WriteLine("2. {0}", unit2);

        int convertToUnit;
        while (!int.TryParse(Console.ReadLine(), out convertToUnit) || convertToUnit < 1 || convertToUnit > 2)
        {
            Console.WriteLine("Invalid selection. Please enter 1 or 2:");
        }

        switch (convertToUnit)
        {
            case 1:
                Console.WriteLine("{0} {1} is equal to {2} {3}", value, unit2, value1, unit1);
                break;
            case 2:
                Console.WriteLine("{0} {1} is equal to {2} {3}", value, unit2, value2, unit2);
                break;
        }

        Console.WriteLine("- - - - - - - - - - - - - - - - ");
        Console.ReadLine();
    }
}



