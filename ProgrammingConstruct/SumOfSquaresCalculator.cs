using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct
{
    internal class SumOfSquaresCalculator
    {
        public int CalculateSumOfSquares(int numb)
        {
            int sum = 0;

            for (int i = 1; i <= numb; i++)
            {
                sum += i * i;
            }

            return sum;
        }
    }
}
