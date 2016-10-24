using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurveys.RackerRank.Warmup.TimeConversion
{
    public class Solution
    {
        /*
        static void Main(String[] args)
        {
            string time = Console.ReadLine();
        }
        */
        public static string TimeConversion(string time)
        {
            string[] timeSplit = time.Split(':');

            int hour = Int32.Parse(timeSplit[0]);
            int minute = Int32.Parse(timeSplit[1]);
            int second = Int32.Parse(timeSplit[2].Substring(0, 2));

            bool isPM = time.Contains("PM");

            if (!isPM && hour == 12)
                hour = 0;
            else if (isPM && hour < 12)
                hour += 12;

            string res = hour.ToString("D2") + ":" + minute.ToString("D2") + ":" + second.ToString("D2");

            return res;
        }
    }
}
