// 2024-09-15_CoronelCamila_Module 2: Exercise 2.1 
//Coded by Camila Coronel
using System;
class InchesToCentimetersInteractiveProgram{
  const double CentimetersPerInch = 2.54;
  static void Main()
  {
    Console.Write("Hello there! Please enter the number of inches you want to convert to centimeters: ");
    string input = Console.ReadLine();
    if(double.TryParse(input, out double inches)){
      double centimeters=inches*CentimetersPerInch;
    Console.WriteLine($"{inches} inches is {centimeters} centimeters");
  }
    }
  }

