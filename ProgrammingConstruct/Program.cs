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
                Console.WriteLine("1.Check Two int are equal or not\n2.Check given number is even or odd.");
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
