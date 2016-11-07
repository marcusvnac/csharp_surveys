using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurveys.Codility
{
    /***
     * 
     * https://codility.com/programmers/lessons/7-stacks_and_queues/stone_wall/
     * 
     */
      
    public static class StoneWall
    {
        public static int Solution(int[] H)
        {
            int stones = 0;
            Stack<int> stoneStack = new Stack<int>();

            for (int i = 0; i < H.Length; i++)
            {
                while ((stoneStack.Count > 0) && (stoneStack.Peek() > H[i]))
                    stoneStack.Pop();

                if ((stoneStack.Count > 0) && (stoneStack.Peek() == H[i]))
                    continue;
                else
                {
                    stones += 1;
                    stoneStack.Push(H[i]);
                }                
            }
            return stones;
        }
    }
}