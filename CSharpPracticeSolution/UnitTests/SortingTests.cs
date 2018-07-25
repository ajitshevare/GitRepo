using CSharpPracticeSolution.Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace UnitTests
{
    [TestClass]
    public class SortingTests
    {
        [TestMethod]
        public void Sort_CompareTo_AnonymousMethod()
        {
            var product = new Product();

            List<Product> products = product.GetProducts();
            products.Sort((x,y)=> x.Id.CompareTo(y.Id));
            var sortedProducts = new List<Product>();
            foreach (var item in products)
            {
                sortedProducts.Add(item);
            }

            Assert.AreEqual(1, sortedProducts[0].Id);
            Assert.AreEqual(2, sortedProducts[1].Id);
            Assert.AreEqual(3, sortedProducts[2].Id);

        }

        [TestMethod]
        public void Sort_OrderBy_ExtensionMethod()
        {
            var product = new Product();

            List<Product> products = product.GetProducts();
            var sortedProducts = new List<Product>();
            foreach (var item in products.OrderBy(t => t.Id))
            {
                sortedProducts.Add(item);
            }

            Assert.AreEqual(1, sortedProducts[0].Id);
            Assert.AreEqual(2, sortedProducts[1].Id);
            Assert.AreEqual(3, sortedProducts[2].Id);

        }
    }
}
