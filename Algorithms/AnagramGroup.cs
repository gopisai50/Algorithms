using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Algorithms
{

    //https://leetcode.com/problems/group-anagrams/description/
    internal class AnagramGroup
    {
        public static void main(string[] args)
        {
           var result = GroupAnagrams(new string[2] { "act", "act"});

            Console.ReadKey();
        }


        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var anagrams = new Dictionary<string, List<string>>();

            foreach (var str in strs)
            {
                // Sort the string to get the key
                var sortedStr = new string(str.OrderBy(c => c).ToArray());

                // If the key is not in the dictionary, add it
                if (!anagrams.ContainsKey(sortedStr))
                {
                    anagrams[sortedStr] = new List<string>();
                }

                // Add the original string to the corresponding list
                anagrams[sortedStr].Add(str);
            }

            // Return the grouped anagrams as a list of lists
            return anagrams.Values.ToList<IList<string>>();
        }

        public static IList<IList<string>> GroupAnagrams1(string[] strs)
        {

            List<IList<string>> finalResult = new List<IList<string>>();

            if (strs.Length == 1)
            {
                return new List<IList<string>>() { (new List<string>() { strs[0] }) };
            }

            List<int> pointers = new List<int>();

            for (int i = 0; i < strs.Length; i++)
            {
                if (pointers.Contains(i))
                {
                    continue;
                }
                List<string> result = new List<string>();


                    result.Add(strs[i]);

                for (int j =i+1; j < strs.Length; j++)
                {
                    if (pointers.Contains(j))
                    {
                        continue;
                    }

                    if (IsAnagram(strs[i], strs[j]))
                    {
                      

                            result.Add(strs[j]);

                        pointers.Add(j);
                    }
                }
                finalResult.Add(result);
            }

            return finalResult;

        }


        public static bool IsAnagram(string st1, string st2)
        {
            Hashtable ht1 = new Hashtable();
            Hashtable ht2 = new Hashtable();

            foreach (var c in st1)
            {
                if (ht1.ContainsKey(c))
                {
                    ht1[c] = (int)ht1[c] + 1;
                }
                else
                {
                    ht1.Add(c, 1);
                }
            }

            foreach (var c in st2)
            {
                if (ht2.ContainsKey(c))
                {
                    ht2[c] = (int)ht2[c] + 1;
                }
                else
                {
                    ht2.Add(c, 1);
                }
            }   

            if (ht1.Count == ht2.Count)
            {
                foreach (DictionaryEntry item in ht1)
                {
                   
                    if (!ht2.ContainsKey(item.Key) || (int)ht2[item.Key] != (int)item.Value)
                    {
                        return false;
                    }
                }
                return true;
            }

            return false; 
        }

    }
}
