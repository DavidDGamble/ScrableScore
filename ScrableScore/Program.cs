using System;
using ScrableScore.Models;

namespace ScrableScore
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter a word to find the scrable score: \n[end] to end program \n");
      string userWord = Console.ReadLine();
      if (userWord.ToLower() != "end")
      {
      Console.WriteLine("\n" + Score.ValueScore(Score.SplitWord(userWord.ToLower())) + "\n");
      Main();
      }
    }
  }
}