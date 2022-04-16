using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas_Program
{
    [TestFixture]
    class TriangleTest
    {
        [Test]
        public void TriangleAreaTest()
        {
            //Arrange
            Triangle triangle = new Triangle();
            double a = 4;
            double b = 5;
            double c = 6;
            double s = (a + b + c) / 2;
            double expectedValue = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            //Act
            double actualValue = triangle.Area(a, b, c);
            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void TrianglePerimeterTest()
        {
            //Arrange
            Triangle triangle = new Triangle();
            double a = 4;
            double b = 5;
            double c = 6;
            double expectedValue = a + b + c;
            //Act
            double actualValue = triangle.Perimeter(a, b, c);
            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }

    [TestFixture]
    class RectangleTest
    {
        [Test]
        public void RectangleAreaTest()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();
            double a = 4;
            double b = 5;
            double expectedValue = a * b;
            //Act
            double actualValue = rectangle.Area(a, b);
            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void RectanglePerimeterTest()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();
            double a = 4;
            double b = 5;
            double expectedValue = (a + b) * 2;
            //Act
            double actualValue = rectangle.Perimeter(a, b);
            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }

    [TestFixture]
    class CircleTest
    {
        [Test]
        public void CircleAreaTest()
        {
            //Arrange
            Circle circle = new Circle();
            double a = 4;
            double expectedValue = Math.PI * a * a;
            //Act
            double actualValue = circle.Area(a);
            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void RectanglePerimeterTest()
        {
            //Arrange
            Circle circle = new Circle();
            double a = 4;
            double expectedValue = Math.PI * a * 2;
            //Act
            double actualValue = circle.Perimeter(a);
            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
