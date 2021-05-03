using System;
// using System.Collections.Generic;
// using User.SphinxRiddles;

namespace User
{
  public class Program
  {
    public static void Main()
    {
      Random rnd = new Random();
      string[] riddles = { "What month of the year has 28 days?", "What is full of holes but still holds water?", "I shave every day, but my beard stays the same. What am I?", "I have branches, but no fruit, trunk or leaves. What am I?", "David’s parents have three sons: Snap, Crackle, and what’s the name of the third son?" };
      string[] answers = { "all of them", "a sponge", "a barber", "a bank", "david" };

      int randomRiddle()
      {
        return rnd.Next(riddles.Length);
      }

      for (int index = randomRiddle(); index < riddles.Length; randomRiddle())
      {
        Console.WriteLine(riddles[index]);
        string userAnswer = Console.ReadLine();
        if (userAnswer == answers[index])
        {
          Console.WriteLine("That is correct.");
          index = randomRiddle();
        }
        else
        {
          Console.WriteLine("Sorry that was incorrect. Beat cheeks loser.");
          break;
        }
      }
    }
  }
}