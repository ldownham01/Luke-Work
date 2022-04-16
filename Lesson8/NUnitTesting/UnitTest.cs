using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    [TestFixture]
    class UnitTest
    {
        [Test]
        public void AddTest()
        {
            //Arrange
            Arithmetic c = new Arithmetic();
            int x = 4;
            int y = 4;
            double expectedValue = 8.0;
            //Act
            double actualValue = c.Add(x, y);
            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void SubtractTest()
        {
            //Arrange
            Arithmetic c = new Arithmetic();
            int x = 5;
            int y = 4;
            double expectedValue = 1.0;
            //Act
            double actualValue = c.Subtract(x, y);
            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
