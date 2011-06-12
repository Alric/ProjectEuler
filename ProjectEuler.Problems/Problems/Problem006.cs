using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler.Problems
{
  public class Problem006
  {

    public static long GetDifference()
    {
      var sumOfSquares = GetSumOfSquares(100);
      var squareOfSums = GetSquareOfSums(100);

      return squareOfSums - sumOfSquares;
    }

    public static long GetSumOfSquares(int max)
    {
      long sumOfSquares = 0;

      for (int i = 1;i<=max;i++)
      {
        sumOfSquares += (long)Math.Pow(i, 2);
      }

      return sumOfSquares;
    }

    public static long GetSquareOfSums(int max)
    {
      long squareOfSums = 0;

      for (int i = 1;i<=max;i++)
      {
        squareOfSums += i;
      }

      return (long)Math.Pow(squareOfSums, 2);
    }

  }
}
