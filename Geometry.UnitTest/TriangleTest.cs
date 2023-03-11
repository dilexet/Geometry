using Geometry.BusinessLogicLayer;
using Geometry.BusinessLogicLayer.CustomException;
using Geometry.BusinessLogicLayer.Implementation;
using NUnit.Framework;

namespace Geometry.UnitTest
{
    public class TriangleTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TriangleNegativeSides()
        {
            Assert.Throws<NegativeNumberException>(() =>
            {
                var unused = new Triangle(-3, -4, -5);
            });

            Assert.Throws<NegativeNumberException>(() =>
            {
                var unused = new Triangle(3, -4, -5);
            });

            Assert.Throws<NegativeNumberException>(() =>
            {
                var unused = new Triangle(-3, -4, 5);
            });

            Assert.Throws<NegativeNumberException>(() =>
            {
                var unused = new Triangle(-3, 4, -5);
            });

            Assert.Throws<NegativeNumberException>(() =>
            {
                var unused = new Triangle(-3, 4, 5);
            });

            Assert.Throws<NegativeNumberException>(() =>
            {
                var unused = new Triangle(3, -4, 5);
            });

            Assert.Throws<NegativeNumberException>(() =>
            {
                var unused = new Triangle(3, 4, -5);
            });
        }

        [Test]
        public void TriangleExist()
        {
            Assert.Throws<TriangleNotExistException>(() =>
            {
                var unused = new Triangle(4, 4, 9);
            });
        }

        [Test]
        public void TriangleIsRight()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(true, triangle.IsRightTriangle);
        }

        [Test]
        public void TriangleIsNotRight()
        {
            var triangle = new Triangle(3, 4, 6);
            Assert.AreEqual(false, triangle.IsRightTriangle);
        }

        [Test]
        public void TriangleAreaEqual6()
        {
            Figure triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(6, triangle.Square);
        }
        
        [Test]
        public void TriangleAreaTest()
        {
            Figure triangle = new Triangle(5, 6, 7);
            Assert.AreEqual(14.696938456699069d, triangle.Square);
        }
    }
}