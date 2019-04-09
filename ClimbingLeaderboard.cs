using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the climbingLeaderboard function below.
     */
    static int[] climbingLeaderboard(int[] scores, int[] alice) {
        /*
         * Write your code here.
         */
        int[] ranks = new int[scores.Length];
        int rank = 1;
        ranks[0] = rank;
        for (int i = 0; i < ranks.Length - 1; i++)
        {
            if (scores[i+1] == scores[i])
            {
                ranks[i+1] = rank;
            }
            else
            {
                ranks[i+1] = ++rank;
            }
            
        }
       
        
        int[] alicesRank = new int[alice.Length];
        
        for (int j = 0; j < alice.Length; j++)
        {
            int position = findPosition(scores, alice[j]);
            if (position != 0)
            {
               if (scores[position-1] == alice[j])
                   alicesRank[j] = ranks[position-1];
               else if (scores[position-1] > alice[j])
                   alicesRank[j] = ranks[position-1] + 1;
            }
            else
                alicesRank[j] = 1;
            
            
        }
        
        return alicesRank;
       
    }
    
    static int findPosition(int[] scores, int score)
    {
        int min = 0;
        int max = scores.Length - 1;
        
        
        while ((min <= max))
        {
            int mid = (min + max)/2;
            if (scores[mid] == score)
            {
                return mid;
            }
            else if (scores[mid] > score)
            {
                min = mid + 1;
                
            }
            else 
            {
                max = mid - 1;
            }
            
                
        }
       
        return min;
        
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int scoresCount = Convert.ToInt32(Console.ReadLine());

        int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp))
        ;
        int aliceCount = Convert.ToInt32(Console.ReadLine());

        int[] alice = Array.ConvertAll(Console.ReadLine().Split(' '), aliceTemp => Convert.ToInt32(aliceTemp))
        ;
        int[] result = climbingLeaderboard(scores, alice);

        textWriter.WriteLine(string.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
