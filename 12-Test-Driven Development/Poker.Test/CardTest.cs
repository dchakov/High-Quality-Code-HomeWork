namespace Poker.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CardTest
    {
        [TestMethod]
        public void TestCardMethodToStringShouldBeCorrect()
        {
            Card card1 = new Card(CardFace.Ace, CardSuit.Clubs);
            Card card2 = new Card(CardFace.Jack, CardSuit.Diamonds);
            var expected1 = "Ace of Clubs";
            var expected2 = "Jack of Diamonds";
            Assert.AreEqual(expected1, card1.ToString());
            Assert.AreEqual(expected2, card2.ToString());
        }

        [TestMethod]
        public void TestCardIfCardCompareIsWorkingCorrectly()
        {
            Card cardFirst = new Card(CardFace.Ace, CardSuit.Clubs);
            Card cardSecond = new Card(CardFace.Ace, CardSuit.Clubs);
            Assert.AreEqual(cardFirst.ToString(), cardSecond.ToString());
        }
    }
}