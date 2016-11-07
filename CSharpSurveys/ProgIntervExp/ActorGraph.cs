using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurveys.ProgIntervExp
{
    public class ActorGraphNode
    {
        private string name;
        private HashSet<ActorGraphNode> linkedActors;
        private int _baconNumber = -1;

        public ActorGraphNode(string name)
        {
            this.name = name;
            linkedActors = new HashSet<ActorGraphNode>();
        }

        public int BaconNumber { get { return _baconNumber; } }

        public void linkCostar(ActorGraphNode costar)
        {
            linkedActors.Add(costar);
            costar.linkedActors.Add(this);
        }

        public void setBaconNumbers()
        {
            _baconNumber = 0;
            Queue<ActorGraphNode> queue = new Queue<ActorGraphNode>();
            queue.Enqueue(this);
            ActorGraphNode current;

            while ((current = queue.Dequeue()) != null)
            {
                foreach (var actor in current.linkedActors)
                {
                    if (-1 == actor._baconNumber) // if node is unvisited
                    {
                        actor._baconNumber = current._baconNumber + 1;
                        queue.Enqueue(actor);
                    }
                }
            }
        }
    }
}
