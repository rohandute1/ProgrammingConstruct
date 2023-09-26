using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct
{
    internal class NaturalNumberCalculator
    {
        public int CalculateSumOfFirstFiveNaturalNumbers()
        {
            int n = 1; 
            int sum = 0;

            int count = 0;

            while (count < 5)
            {
                sum += n; 
                n++; 
                count++;
            }

            return sum; 
        }
    }
}
