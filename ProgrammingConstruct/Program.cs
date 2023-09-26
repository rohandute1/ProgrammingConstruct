using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Programming Construct problems");

            bool continueExecution = true;
            while (continueExecution)
            {
                Console.WriteLine("Please choose any one of the following program:");
                Console.WriteLine("1.Check Two int are equal or not\n2.Check given number is even or odd.\n" +
                    "3.Voter Eligibility Checker\n4.Find Largest number\n5.Check student eligible for admission or not.");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        IntegerCompare integerCompare = new IntegerCompare();
                        integerCompare.EqualityChecker();
                        break;

                    case 2:
                        NumberChecker checker = new NumberChecker();

                        Console.WriteLine("Enter a number: ");
                        int inputNumber = Convert.ToInt32(Console.ReadLine());

                        checker.CheckEvenOrOdd(inputNumber);
                        break;

                    case 3:
                        VoterEligibilityChecker check = new VoterEligibilityChecker();

                        Console.WriteLine("Enter your age: ");
                        int candidateAge = Convert.ToInt32(Console.ReadLine());

                        check.CheckEligibility(candidateAge);
                        break;

                    case 4:
                        LargestOf3Number processor = new LargestOf3Number();

                        Console.WriteLine("Enter three numbers: ");
                        int numA = Convert.ToInt32(Console.ReadLine());
                        int numB = Convert.ToInt32(Console.ReadLine());
                        int numC = Convert.ToInt32(Console.ReadLine());

                        int largestNum = processor.FindLargestNumber(numA, numB, numC);

                        Console.WriteLine($"The largest number among {numA}, {numB}, and {numC} is: {largestNum}");
                        break;

                    case 5:
                        EligibilityCriteriaChecker eligibilityCheck = new EligibilityCriteriaChecker();

                        Console.WriteLine("Input the marks obtained in Physics: ");
                        int physicsMarks = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Input the marks obtained in Chemistry: ");
                        int chemistryMarks = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Input the marks obtained in Mathematics: ");
                        int mathMarks = Convert.ToInt32(Console.ReadLine());

                        eligibilityCheck.CheckEligibility(physicsMarks, chemistryMarks, mathMarks);
                        break;
                    default:
                        Console.WriteLine("Invalid option, Please select a valid program.");
                        break;
                }
                Console.WriteLine("Do you want to continue?(yes or no)");
                string userInput = Console.ReadLine().ToLower();
                if (userInput != "yes")
                {
                    continueExecution = false;
                }
            }

            Console.ReadLine();
        }
    }
}
