import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
          int numOfLists = sc.nextInt();
        ArrayList<Integer>[] lists = new ArrayList[numOfLists];
        for (int i = 0; i < numOfLists; i++)
        {
        lists[i] = new ArrayList<Integer>();
        int numOfItems = sc.nextInt();
        for (int j = 0; j < numOfItems; j++)
        {
            int item = sc.nextInt();
        lists[i].add(item);
        
        }
        }
        int numOfQueries = sc.nextInt();
        for (int k = 0; k < numOfQueries; k++)
        {
            int x = sc.nextInt();
            int y = sc.nextInt();
            if (x <= numOfLists)
            {
               if (y <= lists[x-1].size())
                  System.out.println(lists[x-1].get(y-1));
                  else
                  System.out.println("ERROR!");
            }
            else
            System.out.println("ERROR!");
        }
        
    }
}