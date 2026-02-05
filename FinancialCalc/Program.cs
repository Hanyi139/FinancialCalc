
using System;

using System.Globalization;
class Program
{
    static void Main()
    {
        Console.WriteLine("===Daily Business Summary===");

        Console.WriteLine("===Daily tool calculates Revenue, profit, and profit margin. \n");

        int salesCount = Readint("Enter number of sales (whole number):");
        decimal averageSale = ReadDecimal("Enter avg sales amount:");
        decimal totalCost = ReadDecimal("Enter total cost of the day:");

        Console.WriteLine();

        decimal revenue = salesCount * averageSale;

        decimal profit = revenue - totalCost;

        decimal margin = revenue == 0m ? 0m : profit / revenue;

        Console.WriteLine("-- Results --");
        Console.WriteLine($"Sales Count: {salesCount:N0}");

        Console.WriteLine($"Revenue: {revenue:C}");
        Console.WriteLine($"Cost: {totalCost:C}");
        Console.WriteLine($"Profit: {profit:C}");
        Console.WriteLine($"Margin: {margin:C}");

        Console.WriteLine($"\nProgram Complete. Press Enter to exit.");
        Console.ReadLine();

        static int Readint(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string? input = Console.ReadLine();
                if (int.TryParse(input, NumberStyles.Integer, CultureInfo.CurrentCulture, out int value)
                    && value >= 0) ;
                {
                    return value;
                }
                Console.WriteLine("Please enter a valid non-negative whole number. \n");
            }
        }

        static decimal ReadDecimal(string prompt)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();

            if (decimal.TryParse(input, NumberStyles.Number, CultureInfo.CurrentCulture, out decimal value)
                && value >= 0m);
            {
                return value;
            }
            Console.WriteLine("Please enter a valid non-integer amount (numbers only).\n");
        }
    }
}