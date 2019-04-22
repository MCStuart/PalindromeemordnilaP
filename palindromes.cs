using System;
using System.Collections.Generic;

namespace PalindromeWords {

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Provide a word: ");
      string userWord = Console.ReadLine();
      bool something = true;
      for (int i = 0; i < userWord.Length / 2; i++)
      {
          if (userWord[i] != userWord[userWord.Length - i - 1])
          {
            something = false;
          }
      }
      if (something == true)
      {
        Console.WriteLine("This is a Palindrome!");
      }
      else
      {
        Console.WriteLine("This is not a Palindrome!");
      }
    }
  }
}
