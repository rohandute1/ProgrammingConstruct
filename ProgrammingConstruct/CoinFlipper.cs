using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct
{
    internal class CoinFlipper
    {
        private int headsCount;
        private int tailsCount;
        private readonly Random random;

        public CoinFlipper()
        {
            headsCount = 0;
            tailsCount = 0;
            random = new Random();
        }

        public void Play()
        {
            while (headsCount < 20 && tailsCount < 20)
            {
                int result = random.Next(2);

                if (result == 0)
                {
                    Console.WriteLine("Heads");
                    headsCount++;
                }
                else
                {
                    Console.WriteLine("Tails");
                    tailsCount++;
                }
            }

            if (headsCount >= 20)
            {
                Console.WriteLine("Heads wins!");
            }
            else
            {
                Console.WriteLine("Tails wins!");
            }
        }
    }
}
