using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurveys.Codility
{
    public static class FrogJmp
    {
        public static int Solution(int X, int Y, int D)
        {
            double aux = Math.Ceiling((Y - X) / (double)D);

            int result = Convert.ToInt32(Math.Ceiling(aux));

            return result;
        }
    }
}
