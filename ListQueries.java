import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
       Scanner sc = new Scanner(System.in);
       int numOfEntries = sc.nextInt();
       ArrayList<Integer> list = new ArrayList<Integer>();
       for (int i = 0; i < numOfEntries; i++)
       {
           int entry = sc.nextInt();
           list.add(entry);

       }
       int numOfQueries = sc.nextInt();
       for (int j = 0; j < numOfQueries; j++)
       {
           String request = sc.next();
           if (request.equals("Insert"))
           {
              int position = sc.nextInt();
              int item = sc.nextInt();
              list.add(position, item);
           }
           else
           {
               int posToDelete = sc.nextInt();
               list.remove(posToDelete);
           }
       }
       for (int n : list)
       {
           System.out.print(n + " ");
       }
    }
}