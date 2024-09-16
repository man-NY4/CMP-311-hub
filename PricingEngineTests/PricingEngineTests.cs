using Microsoft.VisualStudio.TestTools.UnitTesting;
using PricingEngineApp;
namespace PricingEngineTests
{
    [TestClass]
    public class PricingEngineTests
    {
        [TestMethod]
        public void CalculateUnitPrice_BelowMinPrice()
        {
            // arrange
            PricingEngine engine = new PricingEngine(false);
            // act
            decimal unitPrice = engine.CalculateUnitPrice(10, 0.50m);
            // assert
            Assert.AreEqual(unitPrice, 0.50m);
        }
        [TestMethod]
        public void CalculateUnitPrice_MinPrice()
        {
            // arrange
            PricingEngine engine = new PricingEngine(false);
            // act
            decimal unitPrice = engine.CalculateUnitPrice(10, 1.00m);
            // assert
            Assert.AreEqual(unitPrice, 1.000m);
        }
        [TestMethod]
        public void CalculateUnitPrice_BelowMinQty()
        {
            // arrange
            PricingEngine engine = new PricingEngine(false);
            // act
            decimal unitPrice = engine.CalculateUnitPrice(1, 5.000m);
            // assert
            Assert.AreEqual(unitPrice, 5.000m);
        }
        [TestMethod]
        public void CalculateUnitPrice_MinQtyLower()
        {
            // arrange
            PricingEngine engine = new PricingEngine(false);
            // act
            decimal unitPrice = engine.CalculateUnitPrice(10, 5.000m);
            // assert
            Assert.AreEqual(unitPrice, 5.000m);
        }
        [TestMethod]
        public void CalculateUnitPrice_MinQtyUpper()
        {
            // arrange
            PricingEngine engine = new PricingEngine(false);
            // act
            decimal unitPrice = engine.CalculateUnitPrice(20, 5.000m);
            // assert
            Assert.AreEqual(unitPrice, 4.500m);
        }
        [TestMethod]
        public void CalculateUnitPrice_QtyGT20()
        {
            // arrange
            PricingEngine engine = new PricingEngine(false);
            // act
            decimal unitPrice = engine.CalculateUnitPrice(21, 5.000m);
            // assert
            Assert.AreEqual(unitPrice, 4.000m);
        }
        [TestMethod]
        public void CalculateUnitPrice_HolidayBelowMinPrice()
        {
            // arrange
            PricingEngine engine = new PricingEngine(true);
            // act
            decimal unitPrice = engine.CalculateUnitPrice(20, 0.500m);
            // assert
            Assert.AreEqual(unitPrice, 0.500m);
        }
        [TestMethod]
        public void CalculateUnitPrice_HolidayBelowMinTotal()
        {
            // arrange
            PricingEngine engine = new PricingEngine(true);
            // act
            decimal unitPrice = engine.CalculateUnitPrice(1, 999.000m);
            // assert
            Assert.AreEqual(unitPrice, 999.000m);
        }
        [TestMethod]
        public void CalculateUnitPrice_HolidayBelowMinQty()
        {
            // Test the discount for holiday and quantity = 10 and total
            // discounted amount is above the holiday threshold
            // arrange
            PricingEngine engine = new PricingEngine(true);
            // act
            decimal unitPrice = engine.CalculateUnitPrice(10, 1001.000m);
            // assert
            Assert.AreEqual(unitPrice, 900.900m);
        }
        [TestMethod]
        public void CalculateUnitPrice_HolidayMinQty()
        {
            // Test the discount for holiday and quantity = 10 and total
            // discounted amount is above the holiday threshold
            // arrange
            PricingEngine engine = new PricingEngine(true);
            // act
            decimal unitPrice = engine.CalculateUnitPrice(10, 1100.000m);
            // assert
            Assert.AreEqual(unitPrice, 990.00m);
        }
    }
}