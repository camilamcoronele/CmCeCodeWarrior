//2024-10-24_CoronelCamila_Module5:Exercise5.1(Home Sales PT 2)
//Camila Coronel

using System;

class HomeSalesArrays
{
    static void Main(string[] args)
    {
        string[] salespeople = { "Danielle", "Edward", "Francis" };
        char[] initials = { 'D', 'E', 'F' };
        double[] salesTotals = new double[3];
        string input;
        double saleAmount;

        do
        {
            Console.WriteLine("Please enter the initial of the salesperson (D, E, F or Z to quit): ");
            input = Console.ReadLine().ToUpper();

            if (input == "Z") break;

            int salespersonIndex = Array.IndexOf(initials, input[0]);
            if (salespersonIndex != -1)
            {
                Console.WriteLine("Please enter the $ sale amount: ");
                if (double.TryParse(Console.ReadLine(), out saleAmount) && saleAmount > 0)
                {
                    salesTotals[salespersonIndex] += saleAmount;
                }
                else
                {
                    Console.WriteLine("Invalid sale amount. Please enter a valid number greater than 0.");
                }
            }
            else
            {
                Console.WriteLine("Invalid salesperson. Please enter D, E, or F.");
            }

        } while (true);

        double grandTotal = 0;
        double highestSales = 0;
        string highestSalesPerson = "";

        for (int i = 0; i < salesTotals.Length; i++)
        {
            grandTotal += salesTotals[i];
            if (salesTotals[i] > highestSales)
            {
                highestSales = salesTotals[i];
                highestSalesPerson = initials[i].ToString();
            }
        }

        Console.WriteLine($"\nGrand Total: {grandTotal:C}");
        Console.WriteLine($"Highest Sale: {highestSalesPerson}");
    }
}
