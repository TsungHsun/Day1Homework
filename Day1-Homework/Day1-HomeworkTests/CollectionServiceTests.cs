using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day1_Homework;
using Day1_Homework.Entity;
using System.Collections.Generic;

namespace Day1_HomeworkTests
{
    [TestClass]
    public class CollectionServiceTests
    {
        [TestMethod]
        public void SumPropertyValueByGroupCountTest_3筆一組_取Cost總和()
        {
            CollectionService target = new CollectionService();
            var productCollection = this.GenerateProductCollection();
            int groupCount = 3;
            string columnName = "Cost";
            var expected = new int[] { 6, 15, 24, 21 };

            var actual = target.SumPropertyValueByGroupCount(productCollection, columnName, groupCount);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SumPropertyValueByGroupCountTest_4筆一組_取Revenue總和()
        {
            CollectionService target = new CollectionService();
            var productCollection = this.GenerateProductCollection();
            int groupCount = 4;
            string columnName = "Revenue";
            var expected = new int[] { 50, 66, 60 };

            var actual = target.SumPropertyValueByGroupCount(productCollection, columnName, groupCount);

            CollectionAssert.AreEqual(expected, actual);
        }

        private List<Product> GenerateProductCollection()
        {
            List<Product> result = new List<Product>();
            result.Add(new Product() { Id = 1, Cost = 1, Revenue = 11, SellPrice = 21 });
            result.Add(new Product() { Id = 2, Cost = 2, Revenue = 12, SellPrice = 22 });
            result.Add(new Product() { Id = 3, Cost = 3, Revenue = 13, SellPrice = 23 });
            result.Add(new Product() { Id = 4, Cost = 4, Revenue = 14, SellPrice = 24 });
            result.Add(new Product() { Id = 5, Cost = 5, Revenue = 15, SellPrice = 25 });
            result.Add(new Product() { Id = 6, Cost = 6, Revenue = 16, SellPrice = 26 });
            result.Add(new Product() { Id = 7, Cost = 7, Revenue = 17, SellPrice = 27 });
            result.Add(new Product() { Id = 8, Cost = 8, Revenue = 18, SellPrice = 28 });
            result.Add(new Product() { Id = 9, Cost = 9, Revenue = 19, SellPrice = 29 });
            result.Add(new Product() { Id = 10, Cost = 10, Revenue = 20, SellPrice = 30 });
            result.Add(new Product() { Id = 11, Cost = 11, Revenue = 21, SellPrice = 31 });
            return result;
        }
    }
}
