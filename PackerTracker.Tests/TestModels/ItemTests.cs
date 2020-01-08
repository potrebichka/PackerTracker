using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PackerTracker.Models;
using System;

namespace PackerTracker.TestTools
{
    [TestClass]
    public class ItemTest : IDisposable
    {
        public void Dispose()
        {
            Item.ClearAll();
        }

        [TestMethod]
        public void ItemConstructor_CreatesInstanceOfItem_Item()
        {
            Item newItem = new Item("tent", false, true, 0.00, 6);
            Assert.AreEqual(typeof(Item), newItem.GetType());
        }

        [TestMethod]
        public void GetAll_ReturnsAllItems_ItemList()
        {
            Item instance1 = new Item("tent", false, true, 0.00, 6);
            Item instance2 = new Item("sleeping bag", true, true, 0.00, 4);

            List<Item> newList = new List<Item> { instance1, instance2 };
            List<Item> result = Item.GetAll();
            Console.WriteLine(result);
            CollectionAssert.AreEqual(newList, result);
        }
       
    }
}