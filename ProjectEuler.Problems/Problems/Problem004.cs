using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler.Problems
{
  public class Problem004
  {

    public static int LargestPalindrome()
    {
      const int MIN = 100;
      const int MAX = 999;
      int product;
      int largestPalindrome = 0;

      for (int left = MAX; left >= MIN; left--)
      {
        for (int right = MAX; right >= MIN; right--)
        {
          product = left * right;

          if (IsPalindrome(product))
          {
            if (product > largestPalindrome)
            {
              largestPalindrome = product;
            }
          }
        }
      }

      return largestPalindrome;
    }

    public static bool IsPalindrome(int number)
    {
      //Could use reverse chararray. Slower due to more string creation?
      string text = number.ToString();

      switch(text.Length)
      {
        case 3:
          return text[0] == text[2];
        case 4:
          return text[0] == text[3] && text[1] == text[2];
        case 5:
          return text[0] == text[4] && text[1] == text[3];
        case 6:
          return text[0] == text[5] && text[1] == text[4] && text[2] == text[3];
        default:
          throw new ArgumentOutOfRangeException("number", "Only integers of 5 or 6 digits are allowed.");
      }      
    }
  }
}
