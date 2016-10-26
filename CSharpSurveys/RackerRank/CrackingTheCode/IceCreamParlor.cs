using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurveys.RackerRank.CrackingTheCode.IceCreamParlor
{
    public class Solution
    {
        
        static void Main(String[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                int m = Convert.ToInt32(Console.ReadLine());
                int n = Convert.ToInt32(Console.ReadLine());
                string[] a_temp = Console.ReadLine().Split(' ');
                int[] a = Array.ConvertAll(a_temp, Int32.Parse);

                Flavor[] flavors = new Flavor[n];

                for (int i=0; i<n; i++)
                {
                    flavors[i] = new Flavor(i + 1, a[i]);                    
                }

                Array.Sort(flavors, new FlavorComparer()); 

                foreach (var flavor in flavors)
                {
                    int CostComplement = m - flavor.Cost;

                    Flavor secondFlavor = BinarySearch(flavors, CostComplement, flavor.ID);
                    if (secondFlavor != null)
                    {
                        if (flavor.ID < secondFlavor.ID)
                            Console.Write(flavor.ID + " " + secondFlavor.ID);
                        else
                            Console.Write(secondFlavor.ID + " " + flavor.ID);
                        
                        break;
                    }
                }
                Console.WriteLine();
            }            
        }

        public static Flavor BinarySearch(Flavor[] arr, int x, int actualID)
        {
            int left = 0;
            int right = arr.Length - 1;            

            while(left <= right)
            {
                int mid = (left + right) / 2;
                if (arr[mid].Cost == x && arr[mid].ID != actualID)
                    return arr[mid];
                else if (x > arr[mid].Cost)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return null;
        }


        public class Flavor
        {
            private readonly int _ID;
            private readonly int _cost;

            public Flavor(int ID, int cost)
            {
                _cost = cost;
                _ID = ID;
            }

            public int Cost { get { return _cost; }  }
            public int ID { get { return _ID; }  }
        }

        public class FlavorComparer : IComparer
        {
            public int Compare(object x, object y)
            {
                Flavor m = (Flavor)x, n = (Flavor)y;
                int mv = m.Cost, nv = n.Cost;
                return (mv < nv ? -1 : (mv == nv ? 0 : 1));
            }
        }
        
    }
}
