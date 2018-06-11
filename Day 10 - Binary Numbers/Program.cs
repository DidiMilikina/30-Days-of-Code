using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_10___Binary_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            var numberToString = Convert.ToString(number, 2);

            string[] arr = numberToString.Split('0').ToArray();
            int input = arr.Select(x => x.Length).Max();

            Console.WriteLine(input);
        }
    }
}
