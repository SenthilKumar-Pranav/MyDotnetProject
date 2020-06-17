using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassBusinessRule;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPhysicalProduct()
        {
            Product objProduct = new Product();
            objProduct.ProductType = ProductTypes.Physical;
            BusinessRules objBusinessRules = new BusinessRules();
            objBusinessRules.ApplyRules(objProduct);
            Assert.AreEqual(ProductTypes.Physical, objBusinessRules.enumProductTypes);
        }


        [TestMethod]
        public void TestMembershipProduct()
        {
            Product objProduct = new Product();
            objProduct.ProductType = ProductTypes.Membership;
            BusinessRules objBusinessRules = new BusinessRules();
            objBusinessRules.ApplyRules(objProduct);
            Assert.AreEqual(ProductTypes.Membership, objBusinessRules.enumProductTypes);
        }

        [TestMethod]
        public void TestBookProduct()
        {
            Product objProduct = new Product();
            objProduct.ProductType = ProductTypes.Physical;
            objProduct.SubProductType = SubProductTypes.Book;
            BusinessRules objBusinessRules = new BusinessRules();
            objBusinessRules.ApplyRules(objProduct);
            Assert.AreEqual(SubProductTypes.Book, objBusinessRules.enumSubProductTypes);
        }

    }
}
