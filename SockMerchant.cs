static int sockMerchant(int n, int[] ar) {
        int pairCount = 0;
        for (int i = 0; i < ar.Length - 1; i++)
        {
            if (ar[i] == 0)
            {
                continue;
            }
            else
            {
            int valueToMatch = ar[i];
            int j = i+1;
            int valueFound = ar[j++];
            while ((valueToMatch != valueFound) && (j < ar.Length))
            {
                valueFound = ar[j++];
            }
            if (valueToMatch == valueFound)
            {
              //  Console.WriteLine("Found match at {0} and {1}", i, j-1);
                ar[j-1] = 0;
                ar[i] = 0;
                pairCount++;
            }
            }
                       
        }
        // Complete this function
        return pairCount;
    }