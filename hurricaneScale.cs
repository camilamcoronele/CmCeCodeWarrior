//2024-09-29_CoronelCamila_Module3Exercise3.2
using System; 
class hurricaneScale{
  static void Main(string[] args){
    Console.WriteLine("Hello there 👋🏼 Let's classify hurricanes! 💨 🌀 ");
    Console.Write("Please enter the wind speed (mph) that your area is experiencing right now: ");
    double windSpeed = double.Parse(Console.ReadLine());
    Console.WriteLine();

    if (windSpeed < 74){
      Console.WriteLine("Good news!!🎊 the wind speed that you entered is not considered a hurricane! ");
    } else if (windSpeed > 74  && windSpeed <= 95){
      Console.WriteLine("This is considered a category 1 hurricane 👀");
    }
    else if(windSpeed >=96 && windSpeed<=110){
      Console.WriteLine("This is considered a category 2 hurricane, please be careful 💨");
    }
    else if(windSpeed >= 111 && windSpeed <= 129){
      Console.WriteLine("This is considered a category 3 hurricane, devastating damage will occur, please be careful and safe!");
    }
    else if(windSpeed >= 130 && windSpeed <=156){
      Console.WriteLine("This is considered a category 4 hurricane, catastrophic damage will occur, please start to evacuate🫡 ");
    }
    else if(windSpeed >= 157){
      Console.WriteLine("This is a category 5 hurricane, please evacuate as soon as possible and be safe 👍🏻");
    }
  }
}
