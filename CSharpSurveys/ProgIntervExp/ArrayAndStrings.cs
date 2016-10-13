using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurveys.ProgIntervExp
{
    public static class ArrayAndStrings
    {
        public static char FirstNonRepeated(string str)
        {
            Dictionary<char, int> charHash = new Dictionary<char, int>();

            int length = str.Length;
            char c;
            
            // Scan str, building hash table
            for (int i = 0; i < length; i++)
            {
                c = str[i];
                if (charHash.ContainsKey(c))
                {   // increment counter
                    charHash[c] = charHash[c] + 1;
                }
                else
                {
                    charHash.Add(c, 1);
                }
            }

            // Search hash table in order of str
            for (int i = 0; i < length; i++)
            {
                c = str[i];
                if (charHash[c] == 1)
                    return c;
            }
            return '\0';
        }

        public static string RemoveChars(string str, string remove)
        {
            char[] s = str.ToCharArray();
            char[] r = remove.ToCharArray();
            int dst = 0;

            // flags automatically initialized to false, size of 128 assumes ASCII
            bool[] flags = new bool[128];

            // set flags for chars to the removed
            for (int src = 0; src < r.Length; ++src)
            {
                flags[r[src]] = true;
            }

            // loop through all the chars copying only if they aren't flagged
            for (int src = 0; src < s.Length; ++src)
            {
                if(!flags[s[src]])
                {
                    s[dst++] = s[src];
                }
            }
            return new string(s, 0, dst);
        }

        public static char[] ReverseWords(char[] str)
        {
            int size = str.Length;
            int start = 0, end = 0;

            str = ReverseString(str, start, size - 1);
            
            while(end < size)
            {
                if (str[end] != ' ')
                {   // sabe position of beginning of word
                    start = end;
                    // scan to next non-word char
                    while (end < size && str[end] != ' ')
                        end++;
                    // back up to end of word
                    end--;
                    // reverse word
                    ReverseString(str, start, end);
                }
                end++;
            }

            return str;
        }

        public static char[] ReverseString(char[] str, int start, int end)
        {
            char temp;

            while (end > start)
            {
                temp = str[start];
                str[start] = str[end];
                str[end] = temp;

                start++;
                end--;                
            }
            return str;
        }

    }
}
