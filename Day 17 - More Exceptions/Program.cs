using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Calculator
{
    public int power(int n, int p)
    {
        double result;

        if (n < 0 || p < 0)
        {
            throw new Exception("n and p should be non-negative");
        }
        else
        {
            result = Math.Pow((double)n, (double)p);
        }

        return (int)result;
    }
}

namespace Day_17___More_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator myCalculator = new Calculator();
            int T = Int32.Parse(Console.ReadLine());

            while (T-- > 0)
            {
                string[] num = Console.ReadLine().Split();
                int n = int.Parse(num[0]);
                int p = int.Parse(num[1]);

                try
                {
                    int ans = myCalculator.power(n, p);
                    Console.WriteLine(ans);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }
            }
        }
    }
}
