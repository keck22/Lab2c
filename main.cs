using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter a color");
    string color = Console.ReadLine();

    if (color.ToLower() == "yellow" || color.ToLower() == "orange" || color.ToLower() == "red"  || color.ToLower() == "gold" || color.ToLower() == "pink") 
    {
      Console.WriteLine ("Color is warm");
    }
    else if (color.ToLower() == "blue" || color.ToLower() == "purple" || color.ToLower() == "magenta" || color .ToLower() == "green") 
    {
      Console.WriteLine ("Color is cool");
    }
    else if (color.ToLower() == "black" || color.ToLower()== "white" || color.ToLower() == "ivory" || color.ToLower() == "brown" || color.ToLower() == "beige") 
    {
      Console.WriteLine ("Color is neutral");
    }
    else 
    {
      Console.WriteLine("Unable to determine the color tempurature for the color");
    }
  }
}