using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurveys.RackerRank.CrackingTheCode.AmzAbbreviation
{
    public static class Solution
    {

        /*
        public string Abbreviation(string input)
        {
            List<string> abbreviations = new List<string>();
            int n = input.Length;

            if (n < 2)
                return input;

            if (n == 2)
            {
                if (input[0] == input[1])
                    return input[0] + "2";
                else
                    return input;
            }

            for (int i = 0; i < input.Length; i++)
            {
                int c = i + 1;
                while (c < input.Length && input[c] == input[i])
                {
                    c++;
                }
                if (c - i != 1)
                {
                    input = input.Substring(0, i + 1) + (c - i) + S.substring(c);
                    i++;
                }

            }
            return input;
        }
        */

        public static List<string> Abbreviation(string input)
        {
            List<string> abbreviations = new List<string>(); // List containing the abbreviations
            int n = input.Length;   // size of the string

            if (n <= 2) // if the input cannot be abbreviated, return an empty list
                return abbreviations;           
                            
            // Generate all abreviations
            for (int abrInd = 2; abrInd <= n - 1; abrInd++)
            {
                int pos = 0;
                while (pos <= n - abrInd)  
                {
                    StringBuilder sb = new StringBuilder();

                    for (int i = 0; i <= pos - 1; i++)
                    {   // Add the prior characters to the number
                        sb.Append(input[i]);
                    }
                    // Add the number
                    sb.Append(abrInd);

                    for (int i = abrInd + pos; i < n; i++)
                    {   // Add the after characters to the number
                        sb.Append(input[i]);
                    }
                    // Add the new abbreviation to the result list
                    abbreviations.Add(sb.ToString());
                    pos++;
                }
            }
            return abbreviations;
        }
        

        // huinan@amazon.com

    }

}
