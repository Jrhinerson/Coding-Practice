using System;
public static class CodeWarsPractice
{
  // 04-06-25
  // Given a string remove all vowels and return the string without vowels
  public static string Disemvowel(string str)
  {
    string newStr = "";
    string vowels = "aeiou";
    foreach (char letter in str)
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

  // 07-25-25
  // Complete the function so that it finds the average of the three scores passed to it and returns the letter value associated with that grade.
  public static char GetGrade(int s1, int s2, int s3)
  {
    int[] numbers = { s1, s2, s3 };
    double average = numbers.Average();
    if (average >= 90)
      return 'A';
    else if (average >= 80)
      return 'B';
    else if (average >= 70)
      return 'C';
    else if (average >= 60)
      return 'D';
    else
      return 'F';
  }
  // Given a string of digits, you should replace any digit below 5 with '0' and any digit 5 and above with '1'. Return the resulting string.
  public static string FakeBin(string x)
  {
    string newString = "";
    foreach (char letter in x)
    {
      int digit = letter - '0';
      newString = digit < 5 ? newString += "0" : newString += "1";
    }
    return newString;
  }

  // 07/27/25
  // Given an array of integers as strings and numbers, return the sum of the array values as if all were numbers.
  public static int SumMix(object[] x)
  {
    int numberResult = 0;
    foreach (var number in x)
    {
      int fixedNumber = number is string ? int.Parse((string)number) : (int)number;
      numberResult += fixedNumber;
    }
    return numberResult;
  }

  //07/28/25
  // Your classmates asked you to copy some paperwork for them. You know that there are 'n' classmates and the paperwork has 'm' pages.

  public static int Paperwork(int n, int m)
  {
    if (n< 0 || m < 0)
      return 0;
    else
      return (n * m);
  }

  // Your task is to write a function which returns the time since midnight in milliseconds.

  public static int Past(int h, int m, int s)
  {
    return ((h * 3600000) + (m * 60000) + (s * 1000));
  }

  // An isogram is a word that has no repeating letters, consecutive or non-consecutive. Implement a function that determines whether a string that contains only letters is an isogram. Assume the empty string is an isogram. Ignore letter case.

  public static bool IsIsogram(string str)
  {
    string testWord = "";
    foreach (char letter in str)
    {
      if (testWord.Contains(Char.ToLower(letter)))
        return false;
      else
        testWord += Char.ToLower(letter);
    }
    return true;
  }
}