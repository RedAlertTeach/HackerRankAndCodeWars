using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySort
{
    class IceCreamNode : IComparable
    {   public int price;
        public int idNumber;   // item number in the list

        public IceCreamNode(int moneys, int number )
        {
            price = moneys;
            idNumber = number;
        }
        public int CompareTo(object obj)
        {
            IceCreamNode icNode = obj as IceCreamNode;
            if (icNode == null)
                throw new ArgumentException("Object is not an IceCreamNode.");
            if (this.price < icNode.price)
                return -1;
            else if (this.price == icNode.price)
                return 0;
            else
                return 1;
        }

        
    }
    class BinarySearchSolution
    {
        
        public static int binarySearchRecursive(List<IceCreamNode> array, int x, int left, int right)
        {
            if (left > right) // not found
                return 0;
            else
            {
                int mid = (left + right) / 2;
                if (array.ElementAt(mid).price == x)
                    return array.ElementAt(mid).idNumber;
                else if (array.ElementAt(mid).price > x)
                    return binarySearchRecursive(array, x, left, mid - 1);
                else
                    return binarySearchRecursive(array, x, mid + 1, right);
            }
        }
        public static string PrintArray(List<IceCreamNode> input)
        {
            string result = String.Empty;

            for (int i = 0; i < input.Count; i++)
            {
                result = result + " ID " + input[i].idNumber + " Cost " + input[i].price + "\n";
            }
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int dataSets = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < dataSets; i++)
            {
                int money = Convert.ToInt32(Console.ReadLine());
                int flavors = Convert.ToInt32(Console.ReadLine());
                string[] dataAsStrings = Console.ReadLine().Split(' ');
                int[] dataAsInts = Array.ConvertAll(dataAsStrings, Int32.Parse);
                List<IceCreamNode> icNodes = new List<IceCreamNode>();
                for (int j = 0; j < dataAsInts.Length; j++)
                {
                    IceCreamNode icNode = new IceCreamNode(dataAsInts[j], j + 1);
                    icNodes.Add(icNode);
                    
                }
                icNodes.Sort();
                for (int k = 0; k < dataAsInts.Length; k++)
                {
                    int icCost = dataAsInts[k];
                    int needed = money - icCost;
                    int foundID = BinarySearchSolution.binarySearchRecursive(icNodes, needed, 0, icNodes.Count - 1);
                    if ((foundID > 0) && (foundID != (k+1)))
                    {
                        Console.WriteLine("{0} {1}", k+1, foundID );
                        break;
                    }
                }

            }
        }
    }
}
