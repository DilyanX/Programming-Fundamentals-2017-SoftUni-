using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04.Longest_Increasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var seq = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var longestSeq = FindLongestIncreasingSubsequence(seq);
     
            Console.WriteLine(string.Join(" ", longestSeq));
        }

        public static int[] FindLongestIncreasingSubsequence(int[] seq)
        {
            int[] len = new int[seq.Length]; 
            int[] prev = new int[seq.Length];
            int maxLen = 0;
            int lastIndex = -1;

            for (int i = 0; i < seq.Length; i++)
            {
                len[i] = 1;
                prev[i] = -1;

                for (int j = 0; j < i; j++)
                {
                    if (seq[j] < seq[i] && len[j] >= len[i])
                    {
                        len[i] = 1 + len[j];
                        prev[i] = j;
                    }
                }

                if (len[i] > maxLen)
                {
                    maxLen = len[i];
                    lastIndex = i;
                }
            }

            var longestSeq = new List<int>();
            for (int i = 0; i < maxLen; i++)
            {
                longestSeq.Add(seq[lastIndex]);
                lastIndex = prev[lastIndex];
            }

            longestSeq.Reverse();
            return longestSeq.ToArray();
        }
    }
}
