using System;
using KataLCD;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataTest
{
    [TestClass]
    public class LEDTest
    {
        readonly LED led = new LED();

        [TestMethod]
        public void ShowNumberOneLeds()
        {
            string[] one = new string[] { LED._NONE, LED._LEFT, LED._LEFT };

            CollectionAssert.AreEqual(one, led.NumberToLCD(1));
        }

        [TestMethod]
        public void ShowNumberTwoLeds()
        {
            string[] two = new string[] { LED._MIDL, LED._MDLT, LED._MDRT };

            CollectionAssert.AreEqual(two, led.NumberToLCD(2));
        }

        [TestMethod]
        public void ShowNumberThreeLeds()
        {
            string[] three = new string[] { LED._MIDL, LED._MDLT, LED._MDLT };

            CollectionAssert.AreEqual(three, led.NumberToLCD(3));
        }

        [TestMethod]
        public void ShowNumberFiveWithFormat()
        {
            string five = LED._MIDL + '\n' + LED._MDRT + '\n' + LED._MDLT;

            string fiveResponse = LED.ToLCD(5);

            Assert.AreEqual(five, fiveResponse);
        }

        [TestMethod]
        public void ShowNumberZeroWithFormat()
        {
            string zero = LED._MIDL + '\n' + LED._BOTH + '\n' + LED._FULL;

            string zeroResponse = LED.ToLCD(0);

            Assert.AreEqual(zero, zeroResponse);
        }

        [TestMethod]
        public void ShowNumberEightWithFormat()
        {
            string eight = LED._MIDL + '\n' + LED._FULL + '\n' + LED._FULL;

            string eightResponse = LED.ToLCD(8);

            Assert.AreEqual(eight, eightResponse);
        }

        [TestMethod]
        public void ShowNumberNineWithFormat()
        {
            string nine = LED._MIDL + '\n' + LED._FULL + '\n' + LED._MDLT;

            string nineResponse = LED.ToLCD(9);

            Assert.AreEqual(nine, nineResponse);
        }
    }
}
