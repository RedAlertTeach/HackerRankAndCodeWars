using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Garrrett", "Josh", "Jourdan", "Kelly", "Mo", "Ronit", "Viral", "Will", "Caleb", "Chris", "Dylan", "Eric", "Ethan", "Hailey", "Jessie", "Kailynn", "Keegan", "Mason", "Neil", "Richard", "Sam", "Suvid", "Trevor", "Watson" };

            var teams = from i in Enumerable.Range(0, names.Length)
                        group names[i] by i / 3;

            foreach (var team in teams)
                Console.WriteLine("Team: {0}", String.Join(", ",team.ToArray()));

        }
    }
}
