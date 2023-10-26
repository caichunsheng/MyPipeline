using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloTempo
{
    public class DictDemo
    {
        public static void PrintDic()
        {
            // Version 1: create a Dictionary, then add 4 pairs to it.
            var dictionary = new Dictionary<string, int>();
            dictionary.Add("cat", 2);
            dictionary.Add("dog", 1);
            dictionary.Add("llama", 0);
            dictionary.Add("iguana", -1);
            // The dictionary has 4 pairs.
            Console.WriteLine("DICTIONARY 1: " + dictionary.Count);

            Dictionary<string, int> data = new Dictionary<string, int>()
            {
                {"cat", 2},
                {"dog", 1},
                {"llama", 0},
                {"iguana", -1}
            };

            // Part 2: loop over pairs with foreach.
            foreach (KeyValuePair<string, int> pair in data)
            {
                Console.WriteLine("FOREACH KEYVALUEPAIR: {0}, {1}", pair.Key, pair.Value);
            }

            var lunch = new Dictionary<string, int>() { { "carrot", 1 }, { "pear", 4 }, { "apple", 6 }, { "kiwi", 3 } };
            Console.WriteLine("COUNT: " + lunch.Count);

            // Remove pear.
            lunch.Remove("pear");
            Console.WriteLine("COUNT: " + lunch.Count);
        }
    }
}
