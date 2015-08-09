using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Poker.Test
{
    [TestClass]
    public class HandTest
    {
        private static IList<ICard> cards = new List<ICard>(){
                new Card(CardFace.Ace,CardSuit.Clubs),
                new Card(CardFace.Ace,CardSuit.Diamonds),
                new Card(CardFace.Ace,CardSuit.Spades),
                new Card(CardFace.Jack,CardSuit.Clubs),
                new Card(CardFace.Jack,CardSuit.Diamonds)
            };
        Hand hand = new Hand(cards);

        [TestMethod]
        public void TestHandIfContainsFiveCards()
        {
            Assert.AreEqual(5, hand.Cards.Count);
        }

        [TestMethod]
        public void TestHandIfToStringMethodWorksCorrectly()
        {
            Assert.AreEqual("Ace of Clubs, Ace of Diamonds, Ace of Spades, Jack of Clubs, Jack of Diamonds", hand.ToString());
        }
    }
}