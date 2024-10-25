// Camila Coronel 
// 2024/10/09_CoronelCamila_Module4Exercise4.1(Perfection)

using System;
class Perfect
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hey there! 👋🏼 We have some questisons for you... Please just answer yes or no...☺️");
        Console.WriteLine("Do you know what Perfect Numbers are...? 👀");
        string input = Console.ReadLine();
        Console.WriteLine();

        if (input.ToLower() == "yes")
        {
            Console.WriteLine("Great! 🥳");
        }
        else if (input.ToLower() == "no")
        {
            Console.WriteLine("That's ok... A number is perfect if it equals the sum of all the smaller positive integers that divide evenly into it");
        }
        Console.WriteLine();
        Console.WriteLine("Ok, let’s practice together some of these numbers!! 👍🏻😀");
        Console.WriteLine("Please enter a number and I will tell you if it is perfect or not...! :) 🔢");
        Console.WriteLine();
        int number = int.Parse(Console.ReadLine());
        if (isPerfect(number))
        {
            Console.WriteLine($"{number} is a perfect number!! 👍🏻");
        }
        else
        {
            Console.WriteLine($"{number} is not a perfect number 👎🏻");
        }
        Console.WriteLine();
        Console.WriteLine("The perfect numbers between 1 and 10000 are: ");
        for (int i = 1; i <= 10000; i++)
        {
            if (isPerfect(i))
            {
                Console.WriteLine(i);
            }
        }
    }
    static bool isPerfect(int number)
    {
        int sum = 0;
        for (int i = 1; i <= number / 2; i++)
        {
            if (number % i == 0)
            {
                sum += i;
            }
        }
        return sum == number;
    }
}