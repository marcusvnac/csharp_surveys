using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurveys.RackerRank.CrackingTheCode.MakingAnagrams
{
    public class Solution
    {
        static void Main(String[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            Console.Write(CharsToDeleteToMakeAnagram(a, b));
        }

        public static int CharsToDeleteToMakeAnagram(string a, string b)
        {
            Dictionary<char, int> charsA = MapChars(a);
            Dictionary<char, int> charsB = MapChars(b);

            int charsToDelete = 0;
            foreach (var c in charsA.Keys)
            {
                if (!charsB.ContainsKey(c))
                    charsToDelete += charsA[c];
                else
                    charsToDelete += Math.Abs(charsB[c] - charsA[c]);
            }

            foreach (var c in charsB.Keys)
            {
                if (!charsA.ContainsKey(c))
                    charsToDelete += charsB[c];                
            }

            return charsToDelete;
        }

        public static Dictionary<char, int> MapChars(string str)
        {
            Dictionary<char, int> result = new Dictionary<char, int>();           

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];

                if (result.ContainsKey(c))
                    result[c]++;
                else
                    result.Add(c, 1);
            }
            return result;
        }
    }

}
