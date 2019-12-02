using System;

namespace day1
{
  class Program
  {
    static void Main(string[] args)
    {
      var input = System.IO.File.ReadAllLines("input.txt");
      long fuel = 0;
      foreach (var line in input)
      {
        fuel = ComputeActual(fuel, Int64.Parse(line));

      }

      Console.WriteLine($"it's {fuel} ");
      Console.WriteLine($"for 12 it's {ComputeFuel(12)}");
      Console.WriteLine($"for 14 it's {ComputeActual(0,14)}");
      Console.WriteLine($"for 1969 it's {ComputeActual(0, 1969)}");
      Console.WriteLine($"for 100756 it's {ComputeActual(0, 100756)}");
      Console.WriteLine($"for 1 it's {ComputeActual(0,1)}");
    }

    private static long ComputeActual(long totalFuel, double input)
    {
      long thisFuel=0;
      do
      {
        thisFuel = ComputeFuel(thisFuel);
        totalFuel += thisFuel;
      }   while (thisFuel > 0);

      return totalFuel;
    }

    private static long ComputeFuel(double line)
    {
      var result = ((long)Math.Floor(line / 3) - 2);
      return result < 0 ? 0: result;
    }
  }
}
