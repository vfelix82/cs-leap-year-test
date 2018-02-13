using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeapYear.Models;
namespace LeapYear.Tests
{
    [TestClass]
    public class YearTest
    {
        [TestMethod, TestCategory("DeckGeneration")]
        public void CheckDeck(){
            Year newLeapYear = new Year(0);
            Assert.AreEqual(true,newLeapYear.CheckForLeapYear(10));
        }


      }
}
