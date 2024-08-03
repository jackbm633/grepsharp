﻿namespace GrepSharp
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Usage: ./grepsharp -E <pattern>");
                Environment.Exit(1);
            }
            string pattern = args[1];
            string inputLine = Console.ReadLine()!;

            if (args[0] != "-E")
            {
                Console.WriteLine("Expected first argument to be '-E'");
                Environment.Exit(1);
            }

            // You can use Console.WriteLine statements for debugging, they'll be visible 
            // when running tests
            Console.WriteLine("Logs from your program will appear here!");

            if (MatchPattern(inputLine, pattern))
            {
                Environment.Exit(0);
            }
            else
            {
                Environment.Exit(1);
            }
            
        }

        static bool MatchPattern(string inputLine, string pattern)
        {
            if (pattern.Length == 1)
            {
                return inputLine.Contains(pattern);
            }
            else
            {
                throw new InvalidDataException($"Unhandled pattern: {pattern}");
            }
        } 
    }

    
}
