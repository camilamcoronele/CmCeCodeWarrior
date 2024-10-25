//Camila Coronel 
//2024-10-13_CoronelCamila_Module4 4.2 (HomeSales)

using System;

class HomeSales
{
    static void Main(string[] args)
    {
        double totalD = 0, totalE = 0, totalF = 0;
        string input;
        double saleAmount;

        do
        {
            Console.WriteLine("Please enter the initial of the salesperson (D, E, F or Z if you want to quit): ");
            input = Console.ReadLine().ToUpper();

            if (input == "Z")
            {
                break;
            }

            if (input == "D" || input == "E" || input == "F")
            {
                Console.WriteLine("Please enter the $ sale amount: ");
                if (double.TryParse(Console.ReadLine(), out saleAmount) && saleAmount > 0)
                {
                    if (input == "D")
                    {
                        totalD += saleAmount;
                    }
                    else if (input == "E")
                    {
                        totalE += saleAmount;
                    }
                    else if (input == "F")
                    {
                        totalF += saleAmount;
                    }
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

        double grandTotal = totalD + totalE + totalF;
        string highestSalesPerson = "";
        double highestSales = 0;

        if (totalD > highestSales)
        {
            highestSales = totalD;
            highestSalesPerson = "D";
        }
        if (totalE > highestSales)
        {
            highestSales = totalE;
            highestSalesPerson = "E";
        }
        if (totalF > highestSales)
        {
            highestSales = totalF;
            highestSalesPerson = "F";
        }

        Console.WriteLine($"\nGrand Total: {grandTotal:C}");
        Console.WriteLine($"Highest Sale: {highestSalesPerson}");
    }
}