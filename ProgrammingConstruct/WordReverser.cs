using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct
{
    internal class WordReverser
    {
        public string ReverseWord(string inputWord)
        {
            string reversedWord = "";
            int length = inputWord.Length;

            while (length > 0)
            {
                length--;
                reversedWord += inputWord[length];
            }

            return reversedWord;
        }
    }
}
