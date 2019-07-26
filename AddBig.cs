using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddBig
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = "123";
            string num2 = "321";
            Console.WriteLine("The sum is {0}", AddBigStrings(num1, num2));
            Console.ReadLine();
        }
        static string AddBigStrings(string num1, string num2)
        {
            StringBuilder sb = new StringBuilder();
            int length1 = num1.Length - 1;
            int length2 = num2.Length - 1;
            int carry = 0;
            while (length1 >= 0 && length2 >= 0)
            {
                int sum = Convert.ToInt16(num1[length1].ToString()) + Convert.ToInt16(num2[length2].ToString()) + carry;
                if (sum > 9)
                {
                    carry = 1;
                    sum = sum - 10;
                }
                else
                    carry = 0;
                sb.Insert(0, sum.ToString());
                
                length1--;
                length2--;
            }
            while (length1 >= 0)
            {
                int sum = Convert.ToInt16(num1[length1].ToString()) + carry;
                if (sum > 9)
                {
                    carry = 1;
                    sum = sum - 10;
                }
                else
                    carry = 0;
                sb.Insert(0, sum.ToString());

                length1--;
            }
            while (length2 >= 0)
            {
                int sum = Convert.ToInt16(num2[length2].ToString()) + carry;
                if (sum > 9)
                {
                    carry = 1;
                    sum = sum - 10;
                }
                else
                    carry = 0;
                sb.Insert(0, sum.ToString());

                length2--;
            }
            if (carry == 1)
                sb.Insert(0, carry.ToString());
            return sb.ToString();
        }
    }
}
