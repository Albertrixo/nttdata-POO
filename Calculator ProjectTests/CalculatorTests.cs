using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator_Project.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        Calculator calculator = new Calculator();
        [TestMethod()]
        public void AddTest()
        {   
            
            Assert.IsTrue(calculator.Add(2, 2) == 4);
            Assert.IsFalse(calculator.Add(2, 2) == 3);
        }

        [TestMethod()]
        public void SubstractTest()
        {
            
            Assert.IsTrue(calculator.Substract(2, 2) == 0);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            
            Assert.IsTrue(calculator.Multiply(4, 4) == 16);
        }

        [TestMethod()]
        public void DivideTest()
        {
            
            Assert.IsTrue(calculator.Divide(6, 2) == 3);
        }
    }
}