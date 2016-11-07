using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurveys.ProgIntervExp
{
    public static class Recursion
    {
        public static int Factorial(int n)
        {
            if (n > 1)
            {
                return n * Factorial(n - 1);
            }
            else
                return 1;
        }

        public static int FactorialIterative(int n)
        {
            int val = 1;

            for (int i = n; i > 1; i--)
            {
                val *= i;
            }
            return val;
        }

        public static int[] AllFactorials(int n)
        {
            int[] results = new int[n == 0 ? 1 : n];
            DoAllFactorials(n, results, 0);
            return results;
        }

        private static int DoAllFactorials(int n, int[] results, int level)
        {
            if (n > 1)
            {
                results[level] = n * DoAllFactorials(n - 1, results, level + 1);
                return results[level];
            }
            else
            {
                results[level] = 1;
                return 1;
            }

        }


        // it expects a sorted array
        public static int BinarySearch(int[] array, int target)
        {
            return BinarySearch(array, target, 0, array.Length - 1);
        }

        private static int BinarySearch(int[] array, int target, int lower, int upper)
        {
            int range = upper - lower;

            if (range < 0)  // Limits reversed
                return -1;
            else if (range == 0 && array[lower] != target)  // element is not i array
                return -1;

            if (array[lower] > array[upper])    // Array not sorted
                return -1;

            int center = (range / 2) + lower;

            if (target == array[center])
                return center;
            else if (target < array[center])
                return BinarySearch(array, target, lower, center - 1);
            else
                return BinarySearch(array, target, center + 1, upper);
        }

        public static int BinarySearchIterative(int[] array, int target)
        {
            int lower = 0, upper = array.Length - 1;

            if (lower > upper)  // limits reversed
                return -1;

            int center, range;
            while(true)
            {
                range = upper - lower;

                if (range == 0 && array[lower] != target)   // element is not in array
                    return -1;

                if (array[lower] > array[upper])    // array is not sorted
                    return -1;

                center = (range / 2) + lower;

                if (target == array[center])
                    return center;
                else if (target < array[center])
                    upper = center - 1;
                else
                    lower = center + 1;
            }

        }
    }

    #region PermutationsProblem
    public class Permutations
    {
        private bool[] used;
        private StringBuilder outStr = new StringBuilder();
        private List<string> _permutationList = new List<string>();
        private string inStr;

        public Permutations(string str)
        {
            inStr = str;
            used = new bool[inStr.Length];
        }

        public List<string> PermutationList { get { return _permutationList; } }


        public void Permute()
        {
            if (outStr.Length == inStr.Length)
            {
                _permutationList.Add(outStr.ToString());
                return;
            }

            for (int i = 0; i < inStr.Length; ++i)
            {
                if (used[i])
                    continue;
                outStr.Append(inStr[i]);
                used[i] = true;
                Permute();
                used[i] = false;
                outStr.Length = outStr.Length - 1;
            }
        }
    }
    #endregion

    #region CombinationsProblem

    public class Combinations
    {
        private StringBuilder outStr = new StringBuilder();
        private List<string> _combinationList = new List<string>();
        private string inStr;

        public Combinations(string str)
        {
            inStr = str;
        }

        public void Combine()
        {
            Combine(0);
        }

        public List<string> CombinationList { get { return _combinationList; } }

        private void Combine(int start)
        {
            for (int i = start; i < inStr.Length; ++i)
            {
                outStr.Append(inStr[i]);
                _combinationList.Add(outStr.ToString());

                if (i < inStr.Length)
                    Combine(i + 1);

                outStr.Length = outStr.Length - 1;
            }
        }
    }
    #endregion

    #region TelephonNumberProblem
    public class TelephoneNumber
    {
        private static readonly int PHONE_NUMBER_LENGTH = 7;
        private int[] phoneNum;
        private char[] result = new char[PHONE_NUMBER_LENGTH];
        private List<string> _wordList = new List<string>();

        public TelephoneNumber(int[] number)
        {
            phoneNum = number;
        }

        public List<string> WordList { get { return _wordList; } }

        public void PrintWords()
        {
            PrintWords(0);
        }

        private void PrintWords(int currDigit)
        {
            if (currDigit == PHONE_NUMBER_LENGTH)
            {
                _wordList.Add(new string(result));
                return;
            }
            for (int i = 1; i <= 3; i++)
            {
                result[currDigit] = GetCharKey(phoneNum[currDigit], i);
                PrintWords(currDigit + 1);
                if (phoneNum[currDigit] == 0 || phoneNum[currDigit] == 1)
                    return;
            }

        }

        public void PrintWordsIteractive()
        {
            StringBuilder buffer = new StringBuilder();
            
            //initialize result with first telephone word
            for (int i = 0; i < PHONE_NUMBER_LENGTH; ++i)
                result[i] = GetCharKey(phoneNum[i], 1);

            while(true)
            {
                for (int i = 0; i < PHONE_NUMBER_LENGTH; ++i)
                    buffer.Append(Char.ToString(result[i]));

                _wordList.Add(buffer.ToString());
                buffer.Clear();

                // start at the end and try do increment from right to left
                for (int i = PHONE_NUMBER_LENGTH -1 ; i >= -1; --i)
                {
                    if (i == -1)    // if attempeted to carry past leftmost digit, finish
                        return;

                    // start with high value, carry caso so 0 and 1 special cases are dealt with right away
                    if (GetCharKey(phoneNum[i], 3) == result[i] || phoneNum[i] == 0 || phoneNum[i] == 1)
                        result[i] = GetCharKey(phoneNum[i], 1);
                        // no break, loop continues to the next digit
                    else if (GetCharKey(phoneNum[i], 1) == result[i])
                    {
                        result[i] = GetCharKey(phoneNum[i], 2);
                        break;
                    }
                    else if (GetCharKey(phoneNum[i], 2) == result[i])
                    {
                        result[i] = GetCharKey(phoneNum[i], 3);
                        break;
                    }
                }
            }
        }

        private char GetCharKey(int telephoneKey, int place)
        {
            place = place - 1;
            char foundChar = '*';
            char[,] telephoneLetters = { { '0', '0', '0' },
                                      { '1', '1', '1' },
                                      { 'A', 'B', 'C' },
                                      { 'D', 'E', 'F' },
                                      { 'G', 'H', 'I' },
                                      { 'J', 'K', 'L' },
                                      { 'M', 'N', 'O' },
                                      { 'P', 'R', 'S' },
                                      { 'T', 'U', 'V' },
                                      { 'W', 'X', 'Y' }
                                    };
            if (telephoneKey >= 0 && telephoneKey <= 9 && place >= 0 && place <= 2)
            {
                foundChar = telephoneLetters[telephoneKey,place];
            }
            return foundChar;
        }
    }

    #endregion
}