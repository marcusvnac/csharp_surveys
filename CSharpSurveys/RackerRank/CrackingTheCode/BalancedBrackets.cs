using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurveys.RackerRank.CrackingTheCode.BalancedBrackets
{
    public class Solution
    {
        /*   
        static void Main(String[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                string expression = Console.ReadLine();
                bool result = IsBracketBalanced(expression);
                if (result)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
        }
        */

        static bool IsBracketBalanced(string s)
        {
            if (s.Length % 2 != 0)
                return false;

            Stack<char> stack = new Stack<char>();

            foreach (var ch in s)
            {
                switch (ch)
                {
                    case '{':
                        stack.Push('}');
                        break;
                    case '[':
                        stack.Push(']');
                        break;
                    case '(':
                        stack.Push(')');
                        break;
                    default:
                        if (stack.Count == 0 || stack.Peek() != ch)
                            return false;

                        stack.Pop();
                        break;
                }
            }
            return stack.Count == 0;
        }

        /*
        public static bool IsBracketBalanced(string brackets)
        {
            // If size is odd, cannot be balanced
            if (brackets.Length % 2 != 0)
                return false;

            Stack<char> halfBracketsStack = CreateStack(brackets);

            for (int i = brackets.Length/2; i < brackets.Length; i++)
            {
                char leftBracket = halfBracketsStack.Pop();
                if (!IsValidCombination(leftBracket, brackets[i]))
                    return false;
            }

            return true;
        }

        private static Stack<char> CreateStack(string brackets)
        {
            Stack<char> result = new Stack<char>();

            for (int i = 0; i < brackets.Length / 2; i++)
                result.Push(brackets[i]);

            return result;
        }

        public static bool IsValidCombination(char left, char right)
        {
            return (left == '(' && right == ')')
                    || (left == '[' && right == ']')
                    || (left == '{' && right == '}');
        }
        */
    }
}
