using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurveys.RackerRank.CrackingTheCode
{
    public class CheckBST
    {
        class Node
        {
            public int data { get; set; }
            public Node left { get; set; }
            public Node right { get; set; }
        }

        bool checkBST(Node root)
        {
            return checkBST(root, null, null);
        }

        bool checkBST(Node root, int? min, int? max)
        {
            if (root == null)
                return true;

            if ((min != null && root.data <= min) || (max != null && root.data >= max))
                return false;

            if (!checkBST(root.left, min, root.data) || !checkBST(root.right, root.data, max))
                return false;

            return true;
        }
    }
}
