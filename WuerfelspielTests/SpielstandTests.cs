using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wuerfelspiel;

namespace WuerfelspielTests
{
    [TestClass]
    public class SpielstandTests
    {
        [TestMethod]
        public void Spielstand_GültigesErstellen()
        {
            // Arrange

            // Act
            Spielstand s1 = new Spielstand();

            // Assert
            Assert.AreEqual(0, s1.Einer);
        }

        #region Einer
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(6)]
        [TestMethod]
        public void Spielstand_EinerGültigerWert(int einerValue)
        {
            // Arrange
            Spielstand s1 = new Spielstand();

            // Act
            s1.Einer = einerValue;

            // Assert
            Assert.AreEqual(einerValue, s1.Einer);
        }

        [DataRow(-1)]
        [DataRow(7)]
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Spielstand_EinerUngültigerWertException(int einerValue)
        {
            // Arrange
            Spielstand s1 = new Spielstand();

            // Act
            s1.Einer = einerValue;
        }

        #endregion

        #region Zweier
        [DataRow(0)]
        [DataRow(2)]
        [DataRow(4)]
        [DataRow(6)]
        [DataRow(8)]
        [DataRow(10)]
        [TestMethod]
        public void Spielstand_ZweierGültigerWert(int zweierValue)
        {
            // Arrange
            Spielstand s1 = new Spielstand();

            // Act
            s1.Zweier = zweierValue;

            // Assert
            Assert.IsTrue(s1.Zweier % 2 == 0 && s1.Zweier < 11 && s1.Zweier >= 0);
        }

        [DataRow(-1)]
        [DataRow(1)]
        [DataRow(3)]
        [DataRow(5)]
        [DataRow(7)]
        [DataRow(9)]
        [DataRow(11)]
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Spielstand_ZweierUngültigerWertException(int zweierValue)
        {
            // Arrange
            Spielstand s1 = new Spielstand();

            // Act
            s1.Zweier = zweierValue;
        }

        #endregion

        #region Dreier
        [DataRow(0)]
        [DataRow(3)]
        [DataRow(6)]
        [DataRow(9)]
        [DataRow(12)]
        [DataRow(15)]
        [TestMethod]
        public void Spielstand_DreierGültigerWert(int dreierValue)
        {
            // Arrange
            Spielstand s1 = new Spielstand();

            // Act
            s1.Dreier = dreierValue;

            // Assert
            Assert.IsTrue(s1.Dreier % 3 == 0 && s1.Dreier < 16 && s1.Dreier >= 0);
        }

        [DataRow(-1)]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(4)]
        [DataRow(5)]
        [DataRow(7)]
        [DataRow(8)]
        [DataRow(10)]
        [DataRow(11)]
        [DataRow(13)]
        [DataRow(14)]
        [DataRow(16)]
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Spielstand_DreierUngültigerWertException(int dreierValue)
        {
            // Arrange
            Spielstand s1 = new Spielstand();

            // Act
            s1.Dreier = dreierValue;
        }

        #endregion

        #region Vierer
        [DataRow(0)]
        [DataRow(4)]
        [DataRow(8)]
        [DataRow(12)]
        [DataRow(16)]
        [DataRow(20)]
        [TestMethod]
        public void Spielstand_ViererGültigerWert(int viererValue)
        {
            // Arrange
            Spielstand s1 = new Spielstand();

            // Act
            s1.Vierer = viererValue;

            // Assert
            Assert.IsTrue(s1.Vierer % 4 == 0 && s1.Vierer < 21 && s1.Vierer >= 0);
        }

        [DataRow(-1)]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(3)]
        [DataRow(5)]
        [DataRow(6)]
        [DataRow(7)]
        [DataRow(9)]
        [DataRow(10)]
        [DataRow(11)]
        [DataRow(13)]
        [DataRow(14)]
        [DataRow(15)]
        [DataRow(17)]
        [DataRow(18)]
        [DataRow(19)]
        [DataRow(21)]
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Spielstand_ViererUngültigerWertException(int viererValue)
        {
            // Arrange
            Spielstand s1 = new Spielstand();

            // Act
            s1.Vierer = viererValue;
        }

        #endregion

        #region Fuenfer
        [DataRow(0)]
        [DataRow(5)]
        [DataRow(10)]
        [DataRow(15)]
        [DataRow(20)]
        [DataRow(25)]
        [TestMethod]
        public void Spielstand_FuenferGültigerWert(int fuenferValue)
        {
            // Arrange
            Spielstand s1 = new Spielstand();

            // Act
            s1.Fuenfer = fuenferValue;

            // Assert
            Assert.IsTrue(s1.Fuenfer % 5 == 0 && s1.Fuenfer < 21 && s1.Fuenfer >= 0);
        }

        [DataRow(-1)]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(3)]
        [DataRow(4)]
        [DataRow(6)]
        [DataRow(7)]
        [DataRow(8)]
        [DataRow(9)]
        [DataRow(11)]
        [DataRow(13)]
        [DataRow(14)]
        [DataRow(16)]
        [DataRow(17)]
        [DataRow(18)]
        [DataRow(19)]
        [DataRow(21)]
        [DataRow(22)]
        [DataRow(23)]
        [DataRow(24)]
        [DataRow(26)]
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Spielstand_FuenferUngültigerWertException(int fuenferValue)
        {
            // Arrange
            Spielstand s1 = new Spielstand();

            // Act
            s1.Fuenfer = fuenferValue;
        }

        #endregion

        #region Sechser
        [DataRow(0)]
        [DataRow(6)]
        [DataRow(12)]
        [DataRow(18)]
        [DataRow(24)]
        [DataRow(30)]
        [TestMethod]
        public void Spielstand_SechserGültigerWert(int sechserValue)
        {
            // Arrange
            Spielstand s1 = new Spielstand();

            // Act
            s1.Sechser = sechserValue;

            // Assert
            Assert.IsTrue(s1.Sechser % 6 == 0 && s1.Sechser < 21 && s1.Sechser >= 0);
        }

        [DataRow(-1)]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(3)]
        [DataRow(4)]
        [DataRow(5)]
        [DataRow(7)]
        [DataRow(8)]
        [DataRow(9)]
        [DataRow(10)]
        [DataRow(11)]
        [DataRow(13)]
        [DataRow(14)]
        [DataRow(15)]
        [DataRow(16)]
        [DataRow(17)]
        [DataRow(19)]
        [DataRow(20)]
        [DataRow(21)]
        [DataRow(22)]
        [DataRow(23)]
        [DataRow(25)]
        [DataRow(26)]
        [DataRow(27)]
        [DataRow(28)]
        [DataRow(29)]
        [DataRow(31)]
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Spielstand_SechserUngültigerWertException(int sechserValue)
        {
            // Arrange
            Spielstand s1 = new Spielstand();

            // Act
            s1.Sechser = sechserValue;
        }

        #endregion

        #region Dreierpasch

        [DataRow(0)]
        [DataRow(3)]
        [DataRow(6)]
        [DataRow(9)]
        [DataRow(12)]
        [DataRow(15)]
        [DataRow(18)]
        [TestMethod]
        public void Spielstand_DreierpaschGültigerWert(int dreierpaschValue)
        {
            // Arrange
            Spielstand s1 = new Spielstand();

            // Act
            s1.Dreierpasch = dreierpaschValue;

            // Assert
            Assert.IsTrue(s1.Dreierpasch % 3 == 0 && s1.Dreierpasch < 19 && s1.Dreierpasch >= 0);
        }

        [DataRow(-1)]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(4)]
        [DataRow(5)]
        [DataRow(7)]
        [DataRow(8)]
        [DataRow(10)]
        [DataRow(11)]
        [DataRow(13)]
        [DataRow(14)]
        [DataRow(16)]
        [DataRow(17)]
        [DataRow(19)]
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Spielstand_DreierpaschUngültigerWertException(int dreierpaschValue)
        {
            // Arrange
            Spielstand s1 = new Spielstand();

            // Act
            s1.Dreierpasch = dreierpaschValue;
        }

        #endregion

        #region Viererpasch

        [DataRow(0)]
        [DataRow(3)]
        [DataRow(6)]
        [DataRow(9)]
        [DataRow(12)]
        [DataRow(15)]
        [DataRow(18)]
        [TestMethod]
        public void Spielstand_ViererpaschGültigerWert(int viererpaschValue)
        {
            // Arrange
            Spielstand s1 = new Spielstand();

            // Act
            s1.Viererpasch = viererpaschValue;

            // Assert
            Assert.IsTrue(s1.Viererpasch % 4 == 0 && s1.Viererpasch < 25 && s1.Viererpasch >= 0);
        }

        [DataRow(-1)]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(3)]
        [DataRow(5)]
        [DataRow(6)]
        [DataRow(7)]
        [DataRow(9)]
        [DataRow(10)]
        [DataRow(11)]
        [DataRow(13)]
        [DataRow(14)]
        [DataRow(15)]
        [DataRow(17)]
        [DataRow(18)]
        [DataRow(19)]
        [DataRow(21)]
        [DataRow(22)]
        [DataRow(23)]
        [DataRow(25)]
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Spielstand_ViererpaschUngültigerWertException(int viererpaschValue)
        {
            // Arrange
            Spielstand s1 = new Spielstand();

            // Act
            s1.Viererpasch = viererpaschValue;
        }

        #endregion

        #region Chance

        [DataRow(0)]
        [DataRow(30)]
        [TestMethod]
        public void Spielstand_ChanceGültigerWert(int chanceValue)
        {
            // Arrange
            Spielstand s1 = new Spielstand();

            // Act
            s1.Chance = chanceValue;

            // Assert
            Assert.AreEqual(chanceValue, s1.Chance);
        }

        [DataRow(-1)]
        [DataRow(31)]
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Spielstand_ChanceUngültigerWertException(int chanceValue)
        {
            // Arrange
            Spielstand s1 = new Spielstand();

            // Act
            s1.Chance = chanceValue;
        }

        #endregion
    }
}
