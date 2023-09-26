using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct
{
    internal class PowerOfTwoTable
    {
        public void PrintTable(int n)
        {
            Console.WriteLine($"Powers of 2 less than or equal to 2^{n}:");

            int power = 1;
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine($"2^{i} = {power}");
                power *= 2;
            }
        }
    }
}
