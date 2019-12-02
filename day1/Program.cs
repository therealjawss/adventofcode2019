using System;

namespace day1
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = System.IO.File.ReadAllLines("input.txt");
            long fuel = 0;
            foreach(var line in input)
      {
        fuel += ComputeFuel(line);
      }
      Console.WriteLine($"it's {fuel} ");
      Console.WriteLine($"for 12 it's {ComputeFuel("12")}");
      Console.WriteLine($"for 12 it's {ComputeFuel("14")}");
      Console.WriteLine($"for 12 it's {ComputeFuel("1969")}");
      Console.WriteLine($"for 12 it's {ComputeFuel("100756")}");
    }

    private static long ComputeFuel(string line)
    {
      return ((long)Math.Floor((double)Int64.Parse(line) / 3) - 2);
    }
  }
}
