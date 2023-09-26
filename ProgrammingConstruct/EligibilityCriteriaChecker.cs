using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct
{
    internal class EligibilityCriteriaChecker
    {
        public void CheckEligibility(int physicsMarks, int chemistryMarks, int mathMarks)
        {
            if (mathMarks >= 65 && physicsMarks >= 55 && chemistryMarks >= 50 && (mathMarks + physicsMarks + chemistryMarks) >= 180)
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else if (mathMarks >= 65 && (physicsMarks + chemistryMarks) >= 140)
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission.");
            }
        }
    }
}
