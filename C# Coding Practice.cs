using System;
public static class CodeWarsPractice
{
// 04-06-25
// Given a string remove all vowels and return the string without vowels
    public static string Disemvowel(string str)
    {
      string newStr = "";
      string vowels = "aeiou";
      foreach(char letter in str)
      {
          if (!vowels.Contains(char.ToLower(letter)))
          {
            newStr += letter;
          }
      }
      return newStr;
    }

    
}