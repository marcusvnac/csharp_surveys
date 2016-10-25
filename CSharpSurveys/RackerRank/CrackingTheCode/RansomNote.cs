using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurveys.RackerRank.CrackingTheCode.RansomNote
{
    public class Solution
    {
        /*
        static void Main(String[] args)
        {
            string[] tokens_m = Console.ReadLine().Split(' ');
            int m = Convert.ToInt32(tokens_m[0]);
            int n = Convert.ToInt32(tokens_m[1]);
            string[] magazine = Console.ReadLine().Split(' ');
            string[] ransom = Console.ReadLine().Split(' ');

            if (CanBuildRansonNote(magazine, ransom))
                Console.Write("Yes");
            else
                Console.Write("No");
        }
        */

        public static bool CanBuildRansonNote(string[] magazine, string[] ransom)
        {
            Dictionary<string, int> magazineWords = MapWords(magazine);
            
            foreach (var word in ransom)
            {
                if (magazineWords.ContainsKey(word) && magazineWords[word] > 0)
                    magazineWords[word]--;
                else
                    return false;
            }
            return true;
        }

        private static Dictionary<string, int> MapWords(string[] magazine)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();

            foreach (var word in magazine)
            {
                if (result.ContainsKey(word))
                    result[word]++;
                else
                    result.Add(word, 1);
            }

            return result;
        }
    }    
}
