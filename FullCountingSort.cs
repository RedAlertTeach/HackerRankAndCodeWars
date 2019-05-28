using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FullCountingSort
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\input.txt";
            FileStream inFile = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inFile);
            int n = Convert.ToInt32(reader.ReadLine().Trim());

            List<List<string>> entries = new List<List<string>>();

            for (int i = 0; i < n; i++)
            {
                entries.Add(reader.ReadLine().TrimEnd().Split(' ').ToList());
            }

            FullCountingSort(entries);

            reader.Close();
            inFile.Close();
            Console.ReadLine();
        }
        static public void FullCountingSort(List<List<string>> numbers)
        {
            Item[] results = new Item[100];
            int count = 1;
            foreach (List<string> item in numbers)
            {
                string[] parts = item.ToArray();
                int index = Convert.ToInt32(parts[0]);
                string text = parts[1];
                if (results[index] == null)
                {
                    results[index] = new Item();
                    results[index].text = new List<string>();
                }
                results[index].count++;
                if (count <= numbers.Count() / 2)
                    text = "-";
                results[index].text.Add(text);
                count++;

            }
            StringBuilder sb = new StringBuilder();
            foreach (Item res in results)
            {
                if (res != null)
                {
                    for (int j = 0; j < res.count; j++)
                    {
                        sb.Append(res.text[j] + " ");
                    }
                    
                }
            }
            sb.Remove(sb.Length - 1, 1);

            Console.Write(sb.ToString()); 
        }
        public class Item
        {
            public int count { get; set; }
            public List<string> text { get; set; }

        }
    }
    
}
