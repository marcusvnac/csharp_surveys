using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurveys.Interviews
{
    public static class AmzAbbreviation
    {
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

        /*  Small improvement in iterative version **/
        public static List<string> Abbreviation2(string input)
        {
            List<string> abbreviations = new List<string>(); // List containing the abbreviations
            int n = input.Length;   // size of the string

            if (n <= 2) // if the input cannot be abbreviated, return an empty list
                return abbreviations;

            // Generate all abreviations
            for (int abrInd = 2; abrInd <= n - 1; abrInd++)
            {
                StringBuilder sb = new StringBuilder();

                for (int pos = 0; pos <= n - abrInd; pos++)
                {   // Add the prior characters to the number
                    string right = input.Substring(abrInd + pos, n - abrInd - pos);

                    if (pos > 0)
                    {
                        string left = input.Substring(0, pos);
                        if (abrInd + pos < n)
                            sb.Append(left + abrInd.ToString() + right);
                        else
                            sb.Append(left + abrInd.ToString());
                    }
                    else
                        sb.Append(abrInd.ToString() + right);

                    // Add the new abbreviation to the result list
                    abbreviations.Add(sb.ToString());
                    sb.Clear();
                }
            }
            return abbreviations;
        }


        /* Recursive approach */
        public static List<string> AbbreviationRecursive(string input)
        {
            List<string> abbreviations = new List<string>(); // List containing the abbreviations
            AbbreviationRecursive(input, 2, 0, abbreviations);
            return abbreviations;
        }

        private static bool AbbreviationRecursive(string input, int idx, int pos, List<string> abbreviations)
        {
            int n = input.Length;   // size of the string

            if (n <= 2              // if the input cannot be abbreviated, return an empty list
                || pos > n - idx)   // or all numbers was inserted
                return true;

            if (idx > n - 1)
            {
                return false;
            }

            StringBuilder sb = new StringBuilder();
            string right = input.Substring(idx + pos, n - idx - pos);
            if (pos > 0)
            {
                string left = input.Substring(0, pos);
                if (idx + pos < n)
                    sb.Append(left + idx.ToString() + right);
                else
                    sb.Append(left + idx.ToString());
            }
            else
                sb.Append(idx.ToString() + right);

            abbreviations.Add(sb.ToString());

            bool result;
            result = AbbreviationRecursive(input, idx, pos + 1, abbreviations);
            result = result && AbbreviationRecursive(input, idx + 1, 0, abbreviations);
            return result;
        }
    }

}
