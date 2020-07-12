import java.math.BigDecimal;
import java.util.*;
class Solution{

    public static void main(String []args){
        //Input
        Scanner sc= new Scanner(System.in);
        int n=sc.nextInt();
        String []s=new String[n+2];
        for(int i=0;i<n;i++){
            s[i]=sc.next();
        }
      	sc.close();
        Comparator compare = new Comparator() {
            
            public int compare(Object o1,Object o2){ 
                if (o1 == null)     // this check is to keep from bombing with null values from the "n+2" above
                   return 1;
                   else if (o2 == null)
                   return -1;
            String s1=(String)o1;  
            String s2=(String)o2;  
            BigDecimal d1 = new BigDecimal(s1);
            BigDecimal d2 = new BigDecimal(s2);
            return d1.compareTo(d2) * -1;  // multiply by -1 because compareTo sorts in ascending and descending is desired
        }
        };
        //Write your code here
        Collections.sort(Arrays.asList(s), compare);

        //Output
        for(int i=0;i<n;i++)
        {
            System.out.println(s[i]);
        }
    }

}