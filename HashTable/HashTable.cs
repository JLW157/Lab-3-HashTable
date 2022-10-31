using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class HashTable<T>
    {
        private Item<T>[] items;

        public HashTable(int size)
        {
            this.items = new Item<T>[size];
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = new Item<T>(i);
            }
        }

        public void Add(T item)
        {
            var key = GetHash(item);

            items[key].Nodes.Add(item);
        }

        public bool Search(T item)
        {
            var key = GetHash(item);
            return items[key].Nodes.Contains(item);
        }

        public bool Remove(T item)
        {
            return items[GetHash(item)].Nodes.Remove(item);
        }

        public void ShowTable()
        {
            foreach (var item in this.items)
            {
                Console.WriteLine($"Key: {item.Key}");
                if (item.Nodes.Count >= 1)
                {
                    foreach (var nodeItem in item.Nodes)
                    {
                        Console.WriteLine($"\t{nodeItem}");
                    }
                }
                else
                {
                    Console.WriteLine("\tZero elements.");
                }
            }
        }

        private int GetHash(T item)
        {
            return item.GetHashCode() % items.Length;
        }
    }
}
