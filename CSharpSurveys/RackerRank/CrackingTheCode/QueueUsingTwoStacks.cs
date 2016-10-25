using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurveys.RackerRank.CrackingTheCode.QueueUsingTwoStacks
{
    public class Solution
    {
        enum Operation { None, Enqueue, Dequeue, Print };

        static void Main(String[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());            

            QueueTwoStacks qts = new QueueTwoStacks();
            
            for (int i = 0; i < q; i++)
            {
                string[] query = Console.ReadLine().Split(' ');
                Operation p = (Operation) int.Parse(query[0]);
                string item = query.Length == 2 ? query[1] : null;
                qts.ProcessQuery(p, item);
            }
        }        

        class QueueTwoStacks
        {
            private Stack<string> q1;
            private Stack<string> q2;

            public QueueTwoStacks()
            {
                q1 = new Stack<string>();
                q2 = new Stack<string>();
            }

            public void ProcessQuery(Operation op, string item = null)
            {
                switch(op)
                {
                    case Operation.Enqueue:
                        Enqueue(item);
                        break;
                    case Operation.Dequeue:
                        Dequeue();
                        break;
                    case Operation.Print:
                        PrintFront();
                        break;
                }
            }

            private void PrintFront()
            {
                ProcessQueue();
                Console.WriteLine(q2.Peek());
            }

            private void Dequeue()
            {
                ProcessQueue();
                q2.Pop();                
            }

            private void Enqueue(string item)
            {
                q1.Push(item);
            }

            private void ProcessQueue()
            {
                if(q2.Count == 0)
                    while(q1.Count > 0)
                        q2.Push(q1.Pop());
            }
        }
    }
}
