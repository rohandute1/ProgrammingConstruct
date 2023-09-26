using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct
{
    internal class ArithmaticOperations
    {
        public void ArithmeticOperator(int x, int y)
        {
            Console.WriteLine("Please enetr: \n1 for Addition\n2 for subtraction\n3 for multiplication\n4 for division:");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    int add = x + y;
                    Console.WriteLine("You selected addition operation and addition is:"+ add);
                    break;
                case 2:
                    int sub = x - y;
                    Console.WriteLine("You selected subtraction operation is subtraction is:"+ sub);
                    break;
                case 3:
                    int mul = x * y;
                    Console.WriteLine("You selected multiplication operation is multiplication is:" + mul);
                    break;
                case 4:
                    int div = x / y;
                    Console.WriteLine("You selected division operation is division is:" + div);
                    break;
                default:
                    Console.WriteLine("Please enter correct option.");
                    break;
            }
        }
    }
}
