namespace Poker.Test
{
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class HandTest
    {
        private static IList<ICard> cards = new List<ICard>()
        {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Diamonds)
        };

        private Hand hand = new Hand(cards);

        [TestMethod]
        public void TestHandIfContainsFiveCards()
        {
            Assert.AreEqual(5, this.hand.Cards.Count);
        }

        [TestMethod]
        public void TestHandIfToStringMethodWorksCorrectly()
        {
            Assert.AreEqual("Ace of Clubs, Ace of Diamonds, Ace of Spades, Jack of Clubs, Jack of Diamonds", this.hand.ToString());
        }
    }
}