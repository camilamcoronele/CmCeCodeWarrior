using System;
class MoveEstimator
{
    static void Main()
    {
        const double baseRate = 200;
        const double hourRate = 150;
        const double mileRate = 2;
        //input/ ask user info so that we can calculate or give an estimate 
        Console.WriteLine("Hello there!! Welcome to Malcom Mover, we are happy that you are interested in our services! ");
        Console.WriteLine();
        Console.WriteLine("In order to help you, please enter the number of hours you will need our services: ");
        Console.WriteLine();
        //conert  to double to handle decimals
        Console.WriteLine("Please enter the hours: ");
        double hours = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Please enter the miles");
        double miles = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine();
        //Calculate the total
        double total = baseRate + (hourRate * hours) + (mileRate * miles);

        Console.WriteLine($"The total for your moving will be: ${total}");
    }
}