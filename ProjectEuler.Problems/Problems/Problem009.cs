using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler.Problems
{
  public class Problem009
  {

    public static int[] GetPythagoreanTriplet()
    {
      int a, b, c;

      for (a = 1; a <= 997; a++)
      {
        for (b = a; b <= 998; b++)
        {
          for (c = b; c <= 999; c++)
          {
            if (a + b + c == 1000)
            {
              if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
              {
                return new[] { a, b, c };                
              }
            }
          }
        }
      }
      
      return new int[0];
    }

    public static int GetPythagoreanTripletProduct()
    {
      var triplet = GetPythagoreanTriplet();
      return triplet[0] * triplet[1] * triplet[2];
    }

  }
}
