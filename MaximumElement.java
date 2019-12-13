public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner in = new Scanner(System.in);
        Stack<Integer> theStack = new Stack<Integer>();
        int count = in.nextInt();
        PriorityQueue<Integer> pQueue =  
             new PriorityQueue<Integer>(Collections.reverseOrder()); 
        for (int i = 1; i <= count; i++)
        {
             int command = in.nextInt();
             if (command == 1)
             {
                 int data = in.nextInt();
                 theStack.push(data);
                 pQueue.add(data);
             }
             else if (command == 2)
             {
                pQueue.remove(theStack.peek());
                theStack.pop();
                
             }
             else
                System.out.println(pQueue.peek());
             
        } 
    }