using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multimap
{
    public class MultiMap<V>
    {
        Dictionary<string, List<V>> mapdictionary =new Dictionary<string, List<V>>();

        public void Add(string key, V value)
        {
            // Add a key.
            List<V> list;
            if (this.mapdictionary.TryGetValue(key, out list))
            {
                list.Add(value);
            }
            else
            {
                list = new List<V>();
                list.Add(value);
                this.mapdictionary[key] = list;
            }
        }
        public IEnumerable<string> Keys
        {
            get
            {
                // Get all keys.
                return this.mapdictionary.Keys;
            }
        }

        public List<V> this[string key]
        {
            get
            {
                // Get list at a key.
                List<V> list;
                if (!this.mapdictionary.TryGetValue(key, out list))
                {
                    list = new List<V>();
                    this.mapdictionary[key] = list;
                }
                return list;
            }
        }
    }
}
