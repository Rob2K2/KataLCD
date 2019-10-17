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
            string five = LED._MIDL + '\n' + LED._BOTH + '\n' + LED._FULL;

            string fiveResponse = LED.ToLCD(0);

            Assert.AreEqual(five, fiveResponse);
        }
    }
}
