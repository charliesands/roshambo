using System;
using System.Collections.Generic;

namespace cs_rock_paper_scissors
{
  class Program
  {
    static void Main(string[] args)
    {
      int wins = 0;
      int losses = 0;
      int ties = 0;
      string cont = "";
      Console.Clear();
      Console.WriteLine("Welcome to ROSHAMBO!");
      while (cont != "N")
      {
        List<string> choices = new List<string>() { "ROCK", "PAPER", "SCISSORS" };
        Random rnd = new Random();
        int n = rnd.Next(0, 3);
        Console.WriteLine("Enter your choice (ROCK, PAPER or SCISSORS):");
        string user = Console.ReadLine().ToUpper();
        Console.WriteLine("*****************************************************");
        Console.WriteLine("User: " + user);
        Console.WriteLine("Computer: " + choices[n]);
        if (user == "ROCK" && choices[n] == "SCISSORS")
        {
          Console.WriteLine("User Wins!");
          wins += 1;
        }
        else if (user == "ROCK" && choices[n] == "PAPER")
        {
          Console.WriteLine("Computer Wins :(");
          losses += 1;
        }
        else if (user == "PAPER" && choices[n] == "ROCK")
        {
          Console.WriteLine("User Wins!");
          wins += 1;
        }
        else if (user == "PAPER" && choices[n] == "SCISSORS")
        {
          Console.WriteLine("Computer Wins :(");
          losses += 1;
        }
        else if (user == "SCISSORS" && choices[n] == "ROCK")
        {
          Console.WriteLine("Computer Wins :(");
          losses += 1;
        }
        else if (user == "SCISSORS" && choices[n] == "PAPER")
        {
          Console.WriteLine("User Wins!");
          wins += 1;
        }
        else
        {
          Console.WriteLine("Result: Tie");
          ties += 1;
        }
        Console.WriteLine("*****************************************************");
        Console.WriteLine("Wins: " + wins);
        Console.WriteLine("Losses: " + losses);
        Console.WriteLine("Ties: " + ties);
        Console.WriteLine("*****************************************************");
        Console.WriteLine("Do you want to keep playing? (Y/N):");
        cont = Console.ReadLine().ToUpper();
        Console.WriteLine("*****************************************************");
      }
      Console.WriteLine("Thanks for playing! Come again soon!");
    }

  }
}
