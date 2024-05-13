namespace FirstLab_TiPO.Tests
{
    [TestClass]
    public class MyCalculatorTests
    {
        [TestMethod]
        public void Sum_7and10_17returned()
        {
            int x = 7;
            int y = 10;
            int expected = 17;

            Calculator c = new Calculator();
            int actual = c.Sum(x, y);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Subtract_10and7_3Returned()
        {
            int x = 10;
            int y = 7;
            int expected = 3;

            Calculator c = new Calculator();
            int actual = c.Subtract(x, y);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Multiply_4and5_20Returned()
        {
            int x = 4;
            int y = 5;
            double expected = 20;

            Calculator c = new Calculator();
            double actual = c.Multiply(x, y);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Divide_15and3_5Returned()
        {
            int x = 15;
            int y = 3;
            double expected = 5;

            Calculator c = new Calculator();
            double actual = c.Divide(x, y);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Divide_10and0_ThrowsDivideByZeroException()
        {
            int x = 10;
            int y = 0;

            Calculator c = new Calculator();

            Assert.ThrowsException<DivideByZeroException>(() => c.Divide(x, y));
        }

        [TestMethod]
        public void Sum_Negative5andNegative3_8Returned()
        {
            int x = -5;
            int y = -3;
            int expected = -8;

            Calculator c = new Calculator();
            int actual = c.Sum(x, y);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Subtract_7and10_Negative3Returned()
        {
            int x = 7;
            int y = 10;
            int expected = -3;

            Calculator c = new Calculator();
            int actual = c.Subtract(x, y);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Multiply_Negative4and5_Negative20Returned()
        {
            int x = -4;
            int y = 5;
            double expected = -20;

            Calculator c = new Calculator();
            double actual = c.Multiply(x, y);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Divide_Negative15and3_Negative5Returned()
        {
            int x = -15;
            int y = 3;
            double expected = -5;

            Calculator c = new Calculator();
            double actual = c.Divide(x, y);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Divide_10andNegative2_Negative5Returned()
        {
            int x = 10;
            int y = -2;
            double expected = -5;

            Calculator c = new Calculator();
            double actual = c.Divide(x, y);

            Assert.AreEqual(expected, actual);
        }
    }
}
