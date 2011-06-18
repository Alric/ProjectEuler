using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler.Problems
{

  public class Problem003
  {

    static public long MaxFactor(long number)
    {
      long i = 2;

      //Increment up to sqrt. 
      while (i * i <= number)
      {
        //If i is a factor
        if (number % i == 0)
        {
          //Set number equal to complementary factor 
          //This works because we're working UP to the sqrt; the complements will always be larger.

          number /= i;
        }
        else
        {
          ++i;
        }
      }

      return number;
    }

  }
}
