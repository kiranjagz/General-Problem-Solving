using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General_Problem_Solving.Arrays
{
    internal class GetOddOccurrence
    {
        /// <summary>
        /// Find the odd occurrence in a given array { 1, 2, 1, 3, 2, 3, 3 }
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int GetOddOccurrenceInArray(int[] arr) {

            Dictionary<int, int> hmap = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (hmap.ContainsKey(arr[i]))
                {
                    int val = hmap[arr[i]];

                    // If array element is already present then remove and re-add
                    // increase the count of that element.
                    hmap.Remove(arr[i]);
                    hmap.Add(arr[i], val + 1);
                }
                else

                    // if array element is not present then put
                    // element into the HashMap and initialize
                    // the count to one.
                    hmap.Add(arr[i], 1);
            }

            foreach (var entry in hmap)
            {
                if (entry.Value % 2 != 0)
                {
                    return entry.Key;
                }
            }

            return -1;
        }
    }
}
