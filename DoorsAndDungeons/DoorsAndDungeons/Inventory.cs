using System;
using System.Collections.Generic;

namespace DoorsAndDungeons
{
    public class Inventory
    {
        public List<string> Items { get; set; }

        public Inventory()
        {
            Items = new List<string>();
        }

        public void Add(string item)
        {
            Items.Add(item);
        }

        public bool HasItem(string item)
        {
            return Items.Contains(item);
        }
    }
}
