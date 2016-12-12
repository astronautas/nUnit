using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nUnitProject
{
    [TestFixture]
    class TemperatureConversionTests
    {
        //[SetUp]
        //public void Init()
        //{

        //}

        [Test]
        public void CelsiusToFarenheit()
        {
            var temp = 20.5;
            var expected = 68.9;

            var actual = TemperatureConverter.CelsiusFarenheit(temp, 0);

            Assert.AreEqual(expected, actual);
        }

        //[Test]
        //[Ignore("Implement C to F later")]
        //public void FarenheitToCelsius()
        //{
        //    var temp = 68.9;
        //    var expected = 20.5;

        //    var actual = TemperatureConverter.CelsiusFarenheit(temp, 1);

        //    Assert.AreEqual(expected, actual);
        //    //Assert.AreEqual(expected, Math.Round(actual, 2));
        //}

        //[Test]
        //public void CelsiusToKelvin()
        //{
        //    var temp = 20;
        //    var expected = 293.1;

        //    var actual = TemperatureConverter.CelsiusKelvin(temp, 0);

        //    Assert.AreEqual(expected, actual);
        //}

        //[Test]
        //public void KelvinToCelsius()
        //{
        //    var temp = 0;
        //    var expected = -273.1;

        //    var actual = TemperatureConverter.CelsiusKelvin(temp, 1);

        //    Assert.AreEqual(expected, actual);
        //}

        //[Test]
        //[ExpectedException(typeof(LowerThanAbsoluteZeroException))]
        //public void LowerThanAbsoluteZeroCelsiusToKelvin()
        //{
        //    var temp = -500;

        //    TemperatureConverter.CelsiusKelvin(temp, 0);
        //}

        //[Test]
        //[ExpectedException(typeof(LowerThanAbsoluteZeroException))]
        //public void LowerThanAbsoluteZeroKelvinToCelsius()
        //{
        //    var temp = -1;

        //    TemperatureConverter.CelsiusKelvin(temp, 1);
        //}
    }
}
