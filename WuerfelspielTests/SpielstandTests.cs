using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wuerfelspiel;

namespace WuerfelspielTests
{
    [TestClass]
    public class SpielstandTests
    {
        [TestMethod]
        public void Kniffel_GültigesErstellen()
        {
            // Arrange

            // Act
            Spielstand s1 = new Spielstand();

            // Assert
            Assert.AreEqual(0, s1.Einer);
        }
    }
}
