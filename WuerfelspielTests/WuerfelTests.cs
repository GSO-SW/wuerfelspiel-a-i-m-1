using System;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wuerfelspiel;


namespace WuerfelspielTests
{
    [TestClass]
    public class WuerfelTests
    {
        [TestMethod]
        public void DummyTest()
        {
            // Dieser Test ist hier, um eine GitHub-Funktion zu testen. 
            // Einfach löschen :)
            Assert.IsTrue(true);// is tatsächlich true :O
        }

        [TestMethod]
        public void WuerfelKannErstelltWerden ()
        {
            // Arrange
            int seiten = 6;
            Rectangle rectangle = new Rectangle();

            //Act
            Wuerfel w = new Wuerfel(seiten);

            //Assert
            Assert.AreEqual(6, w.Seiten);
            Assert.AreEqual(true, w.Hold);
            Assert.AreEqual(0, w.Wurfergebnis);
            Assert.AreEqual(rectangle, w.Rectangle);
        }
    }
}
