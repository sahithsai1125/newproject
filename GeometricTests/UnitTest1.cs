using GeometricBL;
namespace GeometricTests
{
    [TestClass]
    public class UnitTest1
    {
        Circle c = new Circle(5, "Red", true);
        Rectangle r = new Rectangle(4, 3, "Green", true);

        [TestMethod]
        public void TestMethod1()
        {
            double excpected = 78.5;
            double actual =c.Area();
            Assert.AreEqual(excpected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            double excpected = 10;
            double actual = c.diameter();
            Assert.AreEqual(excpected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            double excpected = 31.400000000000002;
            double actual = c.Perimeter();
            Assert.AreEqual(excpected, actual);
        }
        [TestMethod]
        public void TestMethod4()
        {
            double excpected = 12;
            double actual = r.Area();
            Assert.AreEqual(excpected, actual);
        }
        [TestMethod]
        public void TestMethod5()
        {
            double excpected = 14;
            double actual = r.Perimeter();
            Assert.AreEqual(excpected, actual);
        }
        [TestMethod]
        public void TestMethod6()
        {
            double excpected = 33.400000000000002;
            double actual = c.Perimeter();
            Assert.AreNotEqual(excpected, actual);
        }

    }
}