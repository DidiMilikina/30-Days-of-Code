using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1___Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            int first;
            double second;
            string third;

            // Read and save an integer, double, and String to your variables.
            first = int.Parse(Console.ReadLine());
            second = double.Parse(Console.ReadLine());
            third = Console.ReadLine();
            // Print the sum of both integer variables on a new line.
            int sumInts = i + first;
            Console.WriteLine(sumInts);
            // Print the sum of the double variables on a new line.
            double sumDoubles = d + second;
            Console.WriteLine(sumDoubles);
            // Concatenate and print the String variables on a new line
            Console.WriteLine(s + third);
            // The 's' variable above should be printed first.
        }
    }
}
