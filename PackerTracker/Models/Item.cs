using System;
using System.Collections.Generic;

namespace PackerTracker.Models
{
    public class Item
    {
        public string Name {get;set;}
        public bool Packed {get;set;}
        public bool Purchased {get;set;}
        public double Price {get;set;} 
        public int Weight {get;set;}
        public int Id {get;set;}
        private static List<Item> _instances = new List<Item> {};
        public Item (string name, bool packed, bool purchased, double price, int weight)
        {
            Name = name;
            Packed = packed;
            Purchased = purchased;
            Price = price;
            Weight = weight;
            _instances.Add(this);
            Id = _instances.Count;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

        public static List<Item> GetAll()
        {
            return _instances;
        }

        public static Item Find(int searchId)
        {
            return _instances[searchId -1];
        }
    }
}