using System;
using System.Text.RegularExpressions;

namespace pracAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Addition of two numbers");
            Console.WriteLine("Enter input in format: n1 + n2");
            string s = Console.ReadLine();
            string pattern = @"(\d+)\s+([+])\s+(\d+)";
            foreach(Match m in Regex.Matches(s,pattern))
            {
                int val1 = Int32.Parse(m.Groups[1].Value);
                int val2 = Int32.Parse(m.Groups[3].Value);
                Console.WriteLine(val1 + val2);
                    
            }
            
        }
    }
}
