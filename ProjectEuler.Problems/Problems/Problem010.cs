using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler.Problems
{
  public class Problem010
  {

    public static long GetSumOfPrimesUpTo2M()
    {
      var primes = PrimeHelper.FindPrimes(2000000);

      long sum = 0;

      foreach(int i in primes)
      {
        sum += i;
      }

      return sum;
    }

  }
}
