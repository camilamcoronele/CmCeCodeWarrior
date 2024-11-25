//2024-11-22_CoronelCamila_Project0-2[Greenville County Fair] GreenvilleRevenue v0.2

using System;
class ProjectGreenville2
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
        const int ticketPrice = 25;

        Console.WriteLine("Please enter the number of contestants from last year: ");
        int lastYearContestants = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("Please provide the number of contestants from this year: ");
        int thisYearContestants = int.Parse(Console.ReadLine());
        Console.WriteLine();

        int revenue = thisYearContestants * ticketPrice;
        Console.WriteLine($"\nLast year's competition had {lastYearContestants} contestants, and this year's competition has {thisYearContestants} contestants.");
        Console.WriteLine();
        Console.WriteLine($"The revenue expected this year is ${revenue}.");
        Console.WriteLine();
        if (thisYearContestants > lastYearContestants * 2)
        { Console.WriteLine("The competition is more than twice as big this year 👀🎊"); }
        else if (thisYearContestants > lastYearContestants)
        {
            Console.WriteLine("The competition is bigger than ever 😄 🎊");
        }
        else { Console.WriteLine("A tighter race this year! Come out and cast your vote!🫣"); }
    }
}