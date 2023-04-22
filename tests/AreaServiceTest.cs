using mindboxTest;
using NUnit.Framework;


namespace WindowsFormsApp1
{
    [TestFixture]
    public class TestService
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void CircleTest1()
        {
            double expected = 0;
            double value = 0;
            double actual = AreaService.GetCircleArea(value);
            Assert.AreEqual(expected, actual, 0.0001);
        }
        [Test]
        public void CircleTest2()
        {
            double expected = 0;
            double value = 0;
            double actual = AreaService.GetCircleArea(value);
            Assert.AreEqual(expected, actual, 0.0001);
        }
        [Test]
        public void CircleTest3()
        {
            double expected = 706.8583;
            double value = 15;
            double actual = AreaService.GetCircleArea(value);
            Assert.AreEqual(expected, actual, 0.0001);
        }


        [Test]
        public void RectangleTest1()
        {
            double expected = 0;
            double sideA = 1;
            double sideB = 2;
            double sideC = 3;
            double actual = AreaService.GetRectangleArea(sideA, sideB, sideC);
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [Test]
        public void RectangleTest2()
        {
            double expected = 182.3842;
            double sideA = 15;
            double sideB = 25;
            double sideC = 32;
            double actual = AreaService.GetRectangleArea(sideA, sideB, sideC);
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [Test]
        public void RectangleTest3()
        {
            double expected = 6;
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            double actual = AreaService.GetRectangleArea(sideA, sideB, sideC);
            Assert.AreEqual(expected, actual, 0.0001);
        }

    }
}
