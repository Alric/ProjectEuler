using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler.Problems
{
  public class Problem005
  {
    private const int MAX_FACTOR = 20;

    public static int EvenlyDivisible()
    {
      int number = 1;

      while (true)
      {
        bool divisibleByAll = true;

        for (int i = MAX_FACTOR; i > 0; i--)
        {
          if (number % i != 0)
          {
            divisibleByAll = false;
            break;
          }
        }

        if (divisibleByAll)
        {
          return number;
        }
        else
        {
          number++;
        }
      }      
    }

  }
}
