using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler.Problems
{
  public class Problem007
  {

    public static int GetNthPrime(int n)
    {
      var primes = PrimeHelper.FindPrimes(n * 50);

      return primes[n];
    }
    
  }
}
