//2024-11-25_CoronelCamila_Project 0-3: [Greenville County Fair] GreenvilleRevenue v0.3

using System;

class GreenvilleProjectVersion3
{
    static void Main(string[] args)
    {
        Console.WriteLine("************************************");
        Console.WriteLine("*  The stars shine in Greenville   *");
        Console.WriteLine("************************************");
        Console.WriteLine();

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Hello 👋🏼 , Please enter a number from the following menu:");
            Console.WriteLine("1. Calculate Greenville Revenue Year-over-year");
            Console.WriteLine("2. Exit");
            Console.WriteLine();

            string userMenuChoice = Console.ReadLine();
            switch (userMenuChoice)
            {
                case "1":
                    CalculateRevenue();
                    break;
                case "2":
                    Console.WriteLine("Thank you for using the Greenville app, see you soon ✌🏻");
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter either 1 or 2.");
                    break;
            }
        }
    }

    static void CalculateRevenue()
    {
        int lastYearContestants = GetValidContestantCount("last year");
        int thisYearContestants = GetValidContestantCount("this year");

        // Display the competition statistics
        Console.WriteLine($"\nLast year's competition had {lastYearContestants} contestants.");
        Console.WriteLine($"This year's competition has {thisYearContestants} contestants.");
        Console.WriteLine($"The revenue expected this year is ${thisYearContestants * 25}.\n");

        // Apply correct conditions
        if (thisYearContestants < lastYearContestants)
        {
            Console.WriteLine("A tighter race this year! Come out and cast your vote!");
        }
        else if (thisYearContestants > lastYearContestants && thisYearContestants < lastYearContestants * 2)
        {
            Console.WriteLine("The competition is bigger than ever!");
        }
        else if (thisYearContestants >= lastYearContestants * 2)
        {
            Console.WriteLine("The competition is more than twice as big this year!");
        }
    }

    static int GetValidContestantCount(string year)
    {
        int contestants;
        do
        {
            Console.WriteLine($"Please provide the number of contestants for {year} (0-30): ");
            if (int.TryParse(Console.ReadLine(), out contestants) && contestants >= 0 && contestants <= 30)
            {
                return contestants;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 0 and 30.");
            }
        } while (true);
    }
}