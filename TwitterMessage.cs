//2024-09-27_CoronelCamila_Module3Exercise3.1
//Coded by Camila Coronel

using System;
class TwitterMessage{
  public static void Main (){
    Console.WriteLine("Hello there! Please insert the message you want to post in here: ");
    Console.WriteLine();
    string userMessage = Console.ReadLine();
    Console.WriteLine();
    if (userMessage.Length <= 140){
      Console.WriteLine("POSTED! Great! We will post your message in a minute!:)");
    } else{
      Console.WriteLine("REJECTED! The message you want to post exceeds the 140 character limit! Please make it shorter! Thanks:)");
    }
  }
}