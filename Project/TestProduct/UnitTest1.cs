using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestProduct
{
    [TestClass]
    public class UnitTest1
    {
        Project.Product product = new Project.Product();
        Project.Catalogue<Project.Product> catalogue = new Project.Catalogue<Project.Product>();

        [TestMethod]
        public void CalculateTax_CalculateTaxCorrectly()
        {
            

            Assert.AreEqual(110, product.CalculateTax(100, 0.1));
            Assert.AreEqual(57.5, product.CalculateTax(50, 0.15));
            Assert.ThrowsException<Exception>(() => product.CalculateTax(0, 0.20));
            Assert.ThrowsException<Exception>(() => product.CalculateTax(20, 0));
            Assert.ThrowsException<Exception>(() => product.CalculateTax(0, 0));
            Assert.ThrowsException<Exception>(() => product.CalculateTax(56, 70));

        }
        [TestMethod]
        public void Add_AddCorrectly()
        {           

            Assert.ThrowsException<NullReferenceException>(() => catalogue.Add(null));
        }

        [TestMethod]
        public void Remove_RemoveCorrectly()
        {          

            Assert.ThrowsException<NullReferenceException>(() => catalogue.Remove(null));
        }

        [TestMethod]
        public void RemoveAtIndex()
        {          

            Assert.ThrowsException<Exception>(() => catalogue.RemoveAtIndex(-1));
            Assert.ThrowsException<Exception>(() => catalogue.RemoveAtIndex(catalogue.CountItems() + 1));

        }

    } 


}
