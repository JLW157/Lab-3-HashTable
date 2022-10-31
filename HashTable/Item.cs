using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class Item<T>
    {
        public int Key { get; set; }
        public List<T> Nodes { get; set; }

        public Item(int key)
        {
            this.Key = key;
            this.Nodes = new List<T>();
        }
    }
}
