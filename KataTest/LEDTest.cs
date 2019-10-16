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
            string[] one = new string[] {  "   ", "  |", "  |" };

            CollectionAssert.AreEqual(one, led.NumberToLCD(1));
        }

        [TestMethod]
        public void ShowNumberTwoLeds()
        {
            string[] two = new string[] { " _ ", " _|", "|_ " };

            CollectionAssert.AreEqual(two, led.NumberToLCD(2));
        }

        [TestMethod]
        public void ShowNumberThreeLeds()
        {
            string[] three = new string[] { " _ ", " _|", " _|" };

            CollectionAssert.AreEqual(three, led.NumberToLCD(3));
        }
    }
}
