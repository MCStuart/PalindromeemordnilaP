using System;
using System.Collections.Generic;

namespace PalindromeWords {

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Provide a word: ");
      string userWord = Console.ReadLine();
      char[] userWordArrayCopy = userWord.ToCharArray();
      Array.Reverse(userWordArrayCopy);
      string reversedUserWord = new string(userWordArrayCopy);
      if (userWord == reversedUserWord)
      {
        Console.WriteLine("This is a Palindrome! Wow!");
      }
      else
      {
        Console.WriteLine("That is not a Palindrome. Sorry.");
      }
    }
  }
}
