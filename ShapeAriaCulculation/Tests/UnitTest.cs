using ShapeAriaCulculation.Shapes;

namespace Tests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void CircleAreaTest()
        {
            var circle = new Circle(5);
            Assert.AreEqual(Math.PI * 25, circle.CalculateArea());
        }

        [TestMethod]
        public void TriangleIsRightTest()
        {
            var trngl = new Triangle(new double[] { 3, 4, 5 });
            Assert.IsTrue(trngl.IsRightTriangle());
        }


        [DataRow(3, 4, 5, 6)]
        [DataRow(4, 5, 5, 9.1658)]
        [DataRow(5, 9, 5, 9.8075)]
        [TestMethod]
        public void TriangleAreaTest(double a, double b, double c, double area)
        {
            var trngl = new Triangle(new double[] { a, b, c });
            Assert.IsTrue(Math.Abs(area - trngl.CalculateArea()) <= 0.001); // ?????????? ??????????? ? ????????? ??????? ?????
        }

        [DataRow(3, 4, 55)]
        [TestMethod]
        public void TriangleNotCorrect(double a, double b, double c)
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                new Triangle(new double[] { a, b, c });
            });
        }
    }
}