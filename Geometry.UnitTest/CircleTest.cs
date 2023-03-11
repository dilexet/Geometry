using Geometry.BusinessLogicLayer;
using Geometry.BusinessLogicLayer.CustomException;
using Geometry.BusinessLogicLayer.Implementation;
using NUnit.Framework;

namespace Geometry.UnitTest
{
    public class CircleTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CircleNegativeRadius()
        {
            Assert.Throws<NegativeNumberException>(() =>
            {
                var unused = new Circle(-3);
            });
        }

        [Test]
        public void CircleAreaTest()
        {
            Figure circle = new Circle(3);
            Assert.AreEqual(28.274333882308138d, circle.Square);
        }
    }
}