using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the mileage to see how interesting it is.");
            int mileage = Convert.ToInt32(Console.ReadLine());
            int interesting = DetermineInterest(mileage, new List<int>() { 1337, 256 });
            if (interesting == 0)
                Console.WriteLine("The number is NOT interesting.");
            else if (interesting == 1)
                Console.WriteLine("An interesting number occurs within the next two miles.");
            else
                Console.WriteLine("This number is INTERESTING!");
            Console.ReadLine();
            
        }
        static public int DetermineInterest(int mileage, List<int> awesomeNumbers)
        {
            if (mileage < 98)
                return 0;

            if (mileage == 98 || mileage == 99)
                return 1;

            int interest = 2;

            for (int i = 0; i <= 2; i++)
            {
                
                if (awesomeNumbers.Contains(mileage + i))
                    return interest;

                string mileageString = Convert.ToString(mileage + i);

                if (Zeroes(mileageString))
                    return interest;

                if (SameDigit(mileageString))
                    return interest;

                if (SequentialUp(mileageString))
                    return interest;

                if (SequentialDown(mileageString))
                    return interest;

                if (Palindrome(mileageString))
                    return interest;

                interest = 1;
            }
            return 0;
        }
        static public bool Zeroes(string miles)
        {
            if (Convert.ToInt32(miles.Substring(1)) == 0)
                return true;
            else
                return false;
        }
        static public bool SameDigit(string miles)
        {
            if (miles.Intersect(miles).Count() == 1)
                return true;
            else
                return false;
        }
        static public bool SequentialUp(string miles)
        {
            char c = miles[0];
            for (int i = 1; i < miles.Length; i++)
            {
                if ((i == miles.Length - 1) && (miles[i] == '0') && (miles[i - 1] == '9'))
                    return true;
                if ((int)c + 1 != (int)miles[i])
                    return false;
                c = miles[i];
            }
           

            return true;
        }
        static public bool SequentialDown(string miles)
        {
            char c = miles[0];
            for (int i = 1; i < miles.Length; i++)
            {
                if ((i == miles.Length - 1) && (miles[i] == '0') && (miles[i - 1] == '1'))
                    return true;
                if ((int)c - 1 != (int)miles[i])
                    return false;
                c = miles[i];
            }


            return true;
        }
        static public bool Palindrome(string miles)
        {
            char[] charArray = miles.ToCharArray();
            Array.Reverse(charArray);

            string reversed = new string(charArray);

            if (miles.Equals(reversed))
                return true;
            else
                return false;
        }
    }
}
