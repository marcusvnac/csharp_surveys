﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurveys.RackerRank.CrackingTheCode.FibonacciNumbers
{
    public class Solution
    {

        public static int Fibonacci(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        /*
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Fibonacci(n));
        }
        */
    }

}