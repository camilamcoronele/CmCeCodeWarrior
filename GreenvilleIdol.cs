//2024-11-11_CoronelCamila_Project 0-1: [Greenville County Fair] GreenvilleRevenue v0.1 

using System; 
class GreenvilleIdol {
  static void Main(string [] args) {
    // Greenville motto
    Console.WriteLine("************************************");
    Console.WriteLine("*  The stars shine in Greenville   *");
    Console.WriteLine("************************************");

    // Display menu in a loop
    bool exit = false;
    while (!exit) {
      Console.WriteLine("Hello 👋🏼 , Please enter a number from the following menu:");
      Console.WriteLine("1. Calculate Greenville Revenue Year-over-year");
      Console.WriteLine("2. Exit");

      string userMenuChoice = Console.ReadLine();
      switch (userMenuChoice) {
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

  static void CalculateRevenue() {
    const int ticketPrice = 25;

    Console.WriteLine("Please enter the number of contestants from last year: ");
    int lastYearContestants = int.Parse(Console.ReadLine());

    Console.WriteLine("Please provide the number of contestants from this year: ");
    int thisYearContestants = int.Parse(Console.ReadLine());

    int revenue = thisYearContestants * ticketPrice;
    bool isBigger = thisYearContestants > lastYearContestants;

    // Display results with more descriptive output
    Console.WriteLine($"\nLast year's competition had {lastYearContestants} contestants, and this year's competition has {thisYearContestants} contestants.");
    Console.WriteLine($"The revenue expected this year is ${revenue}.");

    if (isBigger) {
      Console.WriteLine("This year's competition is bigger than last year's.\n");
    } else {
      Console.WriteLine("This year's competition is smaller than last year's.\n");
    }
  }
}
