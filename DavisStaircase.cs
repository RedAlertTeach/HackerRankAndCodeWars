using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    
        static void Main(string[] args)
        {
            int numberOfStaircases = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numberOfStaircases; i++)
            {
                int numberOfSteps = Convert.ToInt32(Console.ReadLine());
                switch (numberOfSteps)
                {
                    case 1:
                        Console.WriteLine("1");
                        break;
                    case 2:
                        Console.WriteLine("2");
                        break;
                    case 3:
                        Console.WriteLine("4");
                        break;
                    default:
                        int[] stairArray = new int[numberOfSteps];
				        stairArray[0] = 1;
				        stairArray[1] = 2;
				        stairArray[2] = 4;
				        for (int k = 3; k < numberOfSteps; k++)
				        {
					        stairArray[k] = stairArray[k - 1] + stairArray[k - 2] + stairArray[k - 3];
				        }
				        Console.WriteLine(stairArray[numberOfSteps - 1]);
						break;
                }

                
            }
        }
    }

