using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class DictionaryItem
    {
    public DictionaryItem(string data, int occurrences)
        {
        Data = data;
        Occurrences = occurrences;
    }
    public string Data
        {
        get { return _data; }
        set { _data = value; }
    }
    private string _data;
    public int Occurrences
        {
        get { return _occurrences; }
        set { _occurrences = value;}
    }
    private int _occurrences;
   
    
    
}
class Solution {

    static void Main(String[] args) {
        string[] tokens_m = Console.ReadLine().Split(' ');
        int m = Convert.ToInt32(tokens_m[0]);
        int n = Convert.ToInt32(tokens_m[1]);
        if (n <= m)
            {
        string[] magazine = Console.ReadLine().Split(' ');
        string[] ransom = Console.ReadLine().Split(' ');
        Dictionary<string, DictionaryItem> magDictionary = new Dictionary<string, DictionaryItem>();
        DictionaryItem existingItem;
        foreach (string word in magazine)
            { 
               if (!magDictionary.TryGetValue(word, out existingItem))
                   {
                   DictionaryItem newItem = new DictionaryItem(word, 1);
                   magDictionary.Add(word, newItem);
               }
            else
                {
                existingItem.Occurrences++;
            }
               
        }
        bool allFound = true;
        foreach (string word in ransom)
            {
            if (magDictionary.TryGetValue(word, out existingItem))
                {
                if (existingItem.Occurrences == 1)
                   magDictionary.Remove(word);
                else
                    existingItem.Occurrences--;
                }
                else
                {
                allFound = false;
                break;
            }
        }
        if (allFound)
            Console.WriteLine("Yes");
        else
            Console.WriteLine("No");
    }
        else
            Console.WriteLine("No");
    }
}
