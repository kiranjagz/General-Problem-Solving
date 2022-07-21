using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General_Problem_Solving.Strings
{
    internal class ReverseSentence
    {
        /// <summary>
        /// This was just a test to see what I was doing to reverse words in a sentence
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public string ShortReverse(string word)
        {
            char[] chars = word.ToCharArray();
            Array.Reverse(chars);

            return new string(chars);
        }

        public void LongReverse(string word)
        {
            string[] splitWords = word.Split(' ');

            var size = splitWords.Length - 1;

            for (int i = size; size >= 0; size--)
            {
                if (size == 0)
                {
                    Console.Write(splitWords[size]);
                }
                else
                    Console.Write(splitWords[size] + "" + ' ');
            }
        }
    }
}
