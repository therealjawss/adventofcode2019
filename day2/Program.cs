using System;
using System.Linq;

namespace day2
{
    class Program
    {
        static void Main(string[] args)
        {
            var output = Compute(12, 2);
            Console.WriteLine($"{output}");
            int i=0;
            int j=0;
            for(; i< 99; i++) {
                for(j=0; j<99;j++){
                    if (Compute(i, j) == 19690720) {
                        Console.WriteLine($"Noun: {i} Verb  {j} and the answer {100*i + j}");
                        break;
                    }
                }
            }

            Console.WriteLine("End");


        }

        private static long Compute(int noun, int verb)
        {
            var instructions = System.IO.File.ReadAllText("input.txt").Split(',').Select(long.Parse).ToArray();
            instructions[1] = noun;
            instructions[2] = verb;
            int ptr = 0;

            while (instructions[ptr] != 99)
            {
                try
                {
                    ProcessInstruction(instructions, ptr);
                    ptr += 4;

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    break;
                }

            }
            return instructions[0];
        }

        private static void ProcessInstruction(long[] instructions, int ptr)
        {
            
            switch (instructions[ptr])
            {
                case 1:
                    instructions[instructions[ptr + 3]] = instructions[instructions[ptr + 1]] + instructions[instructions[ptr + 2]];
                    break;
                case 2:
                    instructions[instructions[ptr + 3]]  =  instructions[instructions[ptr + 1]] * instructions[instructions[ptr + 2]];
                    break;
                default:
                    throw new Exception("Halt");
            }
        }

        private static void PrintArray(int[] array) {
            foreach(var item in array) {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();

        }
    }
}
