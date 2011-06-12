using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Timers;
using ProjectEuler.Problems;

namespace ProjectEuler.CLI
{
  class Program
  {
    private const int LIMIT = 4000000;

    static void Main(string[] args)
    {
      //long number;

      //while (long.TryParse(Console.ReadLine(), out number))
      //{
      //  long gf = Problem003.MaxFactor(number);
      //  Console.WriteLine(gf);
      //}
      var x = Problem010.GetSumOfPrimesUpTo2M();

      Console.WriteLine(x);

      Console.WriteLine("done...");
      Console.ReadLine();
    }


   
    public static void LogSum(int sum)
    {
      Console.WriteLine("Current Sum: " + sum);
    }
  }
}
