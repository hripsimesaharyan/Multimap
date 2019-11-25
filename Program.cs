using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Multimap
{
    class Program
    {
        static void Main(string[] args)
        {
            //            List<KeyValuePair<string, string>> listofmap = new List<KeyValuePair<string, string>>();
            //            listofmap.Add(new KeyValuePair<string, string>("N1", "Phone Num1"));
            //            listofmap.Add(new KeyValuePair<string, string>("N1", "Phone Num2"));

            //            foreach (KeyValuePair < string, string> item in listofmap)
            //{
            //                Console.WriteLine(item.Key + "=>" + item.Value);
            //            }


            // Create first MultiMap.
            var multiMap = new MultiMap<bool>();
            multiMap.Add("N1", true);
            multiMap.Add("N1", false);
            multiMap.Add("N2", true);

            foreach (string key in multiMap.Keys)
            {
                foreach (bool value in multiMap[key])
                {
                    Console.WriteLine("MULTIMAP: " + key + "=" + value);
                }
            }

            // Create second MultiMap.
            var multiMap2 = new MultiMap<string>();

            multiMap2.Add("froot", "appple");
            multiMap2.Add("froot", "banana");
            multiMap2.Add("K1", "orange");
            multiMap2.Add("K1", "silver");
            multiMap2.Add("K2", "gold");
            multiMap2.Add("K2", "Georgia");
            multiMap2.Add("K2", "Armenia");
            foreach (string key in multiMap2.Keys)
            {
                foreach (string value in multiMap2[key])
                {
                    Console.WriteLine("MULTIMAP2: " + key + "=" + value);
                }
                
            }

            Console.ReadLine();

        }

    }
}

