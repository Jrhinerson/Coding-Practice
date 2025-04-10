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

  // Given an array of strings indicating direction of 1 minute each determine if the given walk will last 10 minutes and return you back to where you started
    public static bool IsValidWalk(string[] walk)
    {
      if (walk.Length != 10) 
        return false;
      var vertical = 0;
      var horizontal = 0;
      foreach (string direction in walk)
      {
          switch (direction)
          {
              case "n":
                  vertical++;
                  break;
              case "s":
                  vertical--;
                  break;
              case "e":
                  horizontal++;
                  break;
              case "w":
                  horizontal--;
                  break;
          }
      }
      return (vertical == 0 && horizontal == 0);
    }

// 04-08-25
  // Given two integers which can be positive or negative, find the sum of all the integers between and including them and return it. 
    public int GetSum(int a, int b)
    {
      if (a == b)
        return a;
      int Larger = Math.Max(a, b);
      int Smaller = Math.Min(a, b);
      int Final = 0;
      for (int i = Smaller; i <= Larger; i++)
      {
        Final += i;
      }
      return Final;
    }

}