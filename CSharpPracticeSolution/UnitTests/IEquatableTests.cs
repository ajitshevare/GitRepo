using CSharpPracticeSolution.IEquatable;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class IEquatableTests
    {

        #region Proucts

        [TestMethod]
        public void Check_TwoProducts_AreEqual()
        {
            var product = new Product("Soap");

            var otherProduct = new Product("Soap");

            Assert.IsTrue(product.Equals(otherProduct));
        }

        [TestMethod]
        public void Check_TwoProducts_AreNotEqual()
        {
            var product = new Product("Soap");

            var otherProduct = new Product("Rest");

            Assert.IsFalse(product.Equals(otherProduct));
        }

        #endregion Products

    }
}
