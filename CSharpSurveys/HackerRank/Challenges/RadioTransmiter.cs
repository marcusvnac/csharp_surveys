using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CSharpSurveys.HackerRank.Challenges.RadioTransmiter
{
    public class Solution
    {
        /*
        static void Main(String[] args) {
            using(StreamReader input = new StreamReader("input.txt")) {
                string[] tokens_n = input.ReadLine().Split(' ');
                Convert.ToInt32(tokens_n[0]);
                int k = Convert.ToInt32(tokens_n[1]);
                string[] x_temp = input.ReadLine().Split(' ');
                int[] x = Array.ConvertAll(x_temp,Int32.Parse);

                Console.WriteLine(Transmiters(k, x));
            }
        }
        */
        public static int Transmiters(int k, int[] houses)
        {
            Array.Sort(houses);

            int transm = 0;
            int diff;
            int leftHouse = 0;
            int rightHouse = 1;

            while (rightHouse < houses.Length)
            {
                if (houses[rightHouse] == houses[leftHouse])
                {
                    rightHouse++;
                    leftHouse++;
                    continue;
                }

                diff = houses[rightHouse] - houses[leftHouse];

                if (diff < k)
                    rightHouse++;
                else
                {
                    transm++;
                    int tmp = 0;
                    leftHouse = rightHouse == 1 ? rightHouse : rightHouse - 1;
                    while (leftHouse < houses.Length - 1)
                    {
                        if (houses[leftHouse + 1] != houses[leftHouse])
                        {
                            tmp += houses[leftHouse + 1] - houses[leftHouse];

                            if (tmp > k)
                            {
                                leftHouse++;
                                break;
                            }
                        }
                        leftHouse++;
                    }

                    rightHouse = leftHouse + 1;
                }
            }
            return transm == 0 ? 1 : transm;
        }
    }
}