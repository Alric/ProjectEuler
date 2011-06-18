using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
  public class PrimeHelper
  {

    public static IList<int> FindPrimes(int max)
    {
      //Initialize list to capacity using Legendre's constant to minimize copying lists as bounds are exceeded
      var vals = new List<int>((int)(max / (Math.Log(max) - 1.08366)));

      var maxSquareRoot = Math.Sqrt(max);

      //Use a BitArray for light-weight collection of numbers already elminated as not prime.
      var eliminated = new System.Collections.BitArray(max + 1);

      //2 is the only even prime, add it here and skip evaluating all even numbers below
      vals.Add(2);

      for (int i = 3; i <= max; i += 2)
      {
        if (!eliminated[i])
        {
          //We only need to evaluate up to sqrt (any non-primes beyond will already be eliminated as a multiple)
          if (i < maxSquareRoot)
          {
            //Eliminate all multiples i (after i squared, lower multiple are already eliminated)
            for (int j = i * i; j <= max; j += 2 * i)
              eliminated[j] = true;
          }

          //Add number to primes if it hasn't been eliminated
          vals.Add(i);
        }
      }
      return vals;
    }

  }
}
