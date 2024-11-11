//2024-11-11_CoronelCamila_Module 5: Exercise 5.2 (TemperaturesComparison)
//Camila Coronel

using System;
using System.Collections.Generic;

class TemperatureComparison
{
    static void Main(string[] args)
    {
        List<int> temperatures = new List<int>();
        const int minTemp = -30;
        const int maxTemp = 130;
        const int numDays = 5;
        int temperature;

        for (int i = 0; i < numDays; i++)
        {
            Console.WriteLine($"Hello 👋🏼, Please enter today's temperature {i + 1} (between {minTemp} and {maxTemp}):");
            while (!int.TryParse(Console.ReadLine(), out temperature) || temperature < minTemp || temperature > maxTemp)
            {
                Console.WriteLine($"Temperature {temperature} is invalid. Please enter a temperature between {minTemp} and {maxTemp}.");
            }
            temperatures.Add(temperature);
        }

        bool isGettingWarmer = true;
        bool isGettingCooler = true;

        for (int i = 1; i < temperatures.Count; i++)
        {
            if (temperatures[i] <= temperatures[i - 1])
            {
                isGettingWarmer = false;
            }
            if (temperatures[i] >= temperatures[i - 1])
            {
                isGettingCooler = false;
            }
        }

        if (isGettingWarmer)
        {
            Console.WriteLine("It’s getting warmer 🌤️😎");
        }
        else if (isGettingCooler)
        {
            Console.WriteLine("It’s getting cooler ❄️🥶");
        }
        else
        {
            Console.WriteLine("It’s a mixed bag!!");
        }

        Console.WriteLine("5-day Temperatures: ");
        foreach (int temp in temperatures)
        {
            Console.Write(temp + " ");
        }
        Console.WriteLine();

        double averageTemp = 0;
        foreach (int temp in temperatures)
        {
            averageTemp += temp;
        }
        averageTemp /= numDays;

        Console.WriteLine($"The average of the temperatures you gave us is {averageTemp:F1} degrees 😊");
    }
}
