using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurveys.RackerRank.CompareTheTriplets
{
    class Solution
    {        
        public class Challenge
        {
            public int score0 { get; set; }
            public int score1 { get; set; }
            public int score2 { get; set; }

            public Challenge(int score0, int score1, int score2)
            {
                this.score0 = score0;
                this.score1 = score1;
                this.score2 = score2;
            }
        }

        public static void ComparisonChallenges(Challenge aliceScore, Challenge bobScore)
        {
            int alice = 0, bob = 0;

            if (aliceScore.score0 > bobScore.score0)
                alice++;
            else if (aliceScore.score0 < bobScore.score0)
                bob++;

            if (aliceScore.score1 > bobScore.score1)
                alice++;
            else if (aliceScore.score1 < bobScore.score1)
                bob++;

            if (aliceScore.score2 > bobScore.score2)
                alice++;
            else if (aliceScore.score2 < bobScore.score2)
                bob++;

            Console.WriteLine(alice + " " + bob);

        }

        static void Main(String[] args)
        {
            string[] tokens_a0 = Console.ReadLine().Split(' ');
            int a0 = Convert.ToInt32(tokens_a0[0]);
            int a1 = Convert.ToInt32(tokens_a0[1]);
            int a2 = Convert.ToInt32(tokens_a0[2]);
            string[] tokens_b0 = Console.ReadLine().Split(' ');
            int b0 = Convert.ToInt32(tokens_b0[0]);
            int b1 = Convert.ToInt32(tokens_b0[1]);
            int b2 = Convert.ToInt32(tokens_b0[2]);

            Challenge alice = new Challenge(a0, a1, a2);
            Challenge bob = new Challenge(b0, b1, b2);

            ComparisonChallenges(alice, bob);

        }
    }
}
