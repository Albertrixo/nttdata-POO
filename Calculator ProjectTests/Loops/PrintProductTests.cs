using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator_Project.Loops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Project.Loops.Tests
{
    [TestClass()]
    public class PrintProductTests
    {
        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
           // if (PrintProduct.products.Count == 0)
                PrintProduct.CreateList();
        }
        [TestMethod()]
        public void GetProductsGreaterThan30WithForEachTest()
        {
            /*if (PrintProduct.products.Count == 0)
                PrintProduct.CreateList();*/
                Assert.IsTrue(PrintProduct.GetProductsGreaterThan30WithForEach().Count == 2);
                Assert.IsTrue(PrintProduct.GetProductsGreaterThan30WithForEach()[0].Name == "Vinagre");
                Assert.IsTrue(PrintProduct.GetProductsGreaterThan30WithForEach()[1].Name == "Juego");
        }

        [TestMethod()]
        public void GetProductsGreaterThan30WithLinQTest()
        {
            /*if (PrintProduct.products.Count == 0)
                PrintProduct.CreateList();*/
                Assert.IsTrue(PrintProduct.GetProductsGreaterThan30WithForEach().Count == 2);
                Assert.IsTrue(PrintProduct.GetProductsGreaterThan30WithForEach()[0].Name == "Vinagre");
                Assert.IsTrue(PrintProduct.GetProductsGreaterThan30WithForEach()[1].Name == "Juego");
            
        }
    }
}