using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> hogwartsDatabase = new Dictionary<int, string>();
            hogwartsDatabase.Add(56, "Rubeus Hagrid");
            hogwartsDatabase.Add(16, "Filch's Cat");

            Dictionary<int, string>.KeyCollection KeyList = hogwartsDatabase.Keys;

            foreach (KeyValuePair<int,string> item in hogwartsDatabase)
            {
                Console.WriteLine("Number: {0} , Name: {1}", item.Key, item.Value);
            }
            Console.ReadLine();
        }
    }
}