using EventMethods;

namespace EventMethodUnitTests
{
    [TestClass]
    public class EventMethodUnitTests
    {
        [TestMethod]
        public void TestDiscountCode_UpperCase()
        {
            // arrange
            Tournament tournament = new Tournament(4032, "Big Games Tourney", 16);
            ITotalFees totalFees = tournament;
            // act
            double checkFees = totalFees.playerCost("D");
            // assert
            Assert.AreEqual(checkFees,144);
        }

        [TestMethod]
        public void TestDiscountCode_LowerCase()
        {
            // arrange
            Tournament tournament = new Tournament(4032, "Big Games Tourney", 16);
            ITotalFees totalFees = tournament;
            // act
            double checkFees = totalFees.playerCost("d");
            // assert
            Assert.AreEqual(checkFees, 144);
        }

        [TestMethod]
        public void TestEmployeeCode_UpperCase()
        {
            // arrange
            Tournament tournament = new Tournament(4032, "Big Games Tourney", 16);
            ITotalFees totalFees = tournament;
            // act
            double checkFees = totalFees.playerCost("E");
            // assert
            Assert.AreEqual(checkFees, 120);
        }

        [TestMethod]
        public void TestEmployeeCode_LowerCase()
        {
            // arrange
            Tournament tournament = new Tournament(4032, "Big Games Tourney", 16);
            ITotalFees totalFees = tournament;
            // act
            double checkFees = totalFees.playerCost("e");
            // assert
            Assert.AreEqual(checkFees, 120);
        }

        [TestMethod]
        public void TestFreeCode_UpperCase()
        {
            // arrange
            Tournament tournament = new Tournament(4032, "Big Games Tourney", 16);
            ITotalFees totalFees = tournament;
            // act
            double checkFees = totalFees.playerCost("F");
            // assert
            Assert.AreEqual(checkFees, 0);
        }

        [TestMethod]
        public void TestFreeCode_LowerCase()
        {
            // arrange
            Tournament tournament = new Tournament(4032, "Big Games Tourney", 16);
            ITotalFees totalFees = tournament;
            // act
            double checkFees = totalFees.playerCost("f");
            // assert
            Assert.AreEqual(checkFees, 0);
        }

        [TestMethod]
        public void TestLateCode_UpperCase()
        {
            // arrange
            Tournament tournament = new Tournament(4032, "Big Games Tourney", 16);
            ITotalFees totalFees = tournament;
            // act
            double checkFees = totalFees.playerCost("L");
            // assert
            Assert.AreEqual(checkFees, 176);
        }

        [TestMethod]
        public void TestLateCode_LowerCase()
        {
            // arrange
            Tournament tournament = new Tournament(4032, "Big Games Tourney", 16);
            ITotalFees totalFees = tournament;
            // act
            double checkFees = totalFees.playerCost("l");
            // assert
            Assert.AreEqual(checkFees, 176);
        }

        [TestMethod]
        public void TestAnythingElse()
        {
            // arrange
            Tournament tournament = new Tournament(4032, "Big Games Tourney", 16);
            ITotalFees totalFees = tournament;
            // act
            double checkFees = totalFees.playerCost("");
            // assert
            Assert.AreEqual(checkFees, 160);
        }

        [TestMethod]
        public void TestAnythingElse2()
        {
            // arrange
            Tournament tournament = new Tournament(4032, "Big Games Tourney", 16);
            ITotalFees totalFees = tournament;
            // act
            double checkFees = totalFees.playerCost("m");
            // assert
            Assert.AreEqual(checkFees, 160);
        }
    }
}