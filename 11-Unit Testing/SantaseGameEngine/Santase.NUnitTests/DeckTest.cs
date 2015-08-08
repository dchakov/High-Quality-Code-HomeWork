namespace Santase.NUnitTests
{
    using System;
    using NUnit.Framework;
    using Santase.Logic;
    using Santase.Logic.Cards;

    [TestFixture]
    public class DeckTest
    {
        [Test]
        public void TestDeckIfNewOneContains24Cards()
        {
            Deck deck = new Deck();
            Assert.AreEqual(24, deck.CardsLeft, "Must contain 24 cards");
        }

        [TestCase(24)]
        [ExpectedException(typeof(InternalGameException))]
        public void TestDeckIfGetNextCartAndDeckIsEmptyThrows(int cards)
        {
            Deck deck = new Deck();
            for (int i = 0; i <= cards; i++)
            {
                deck.GetNextCard();
            }
        }

        [Test]
        public void TestDeckIfGetNextCardReturnsCorrectType()
        {
            Deck deck = new Deck();
            Assert.IsTrue(deck.GetNextCard().GetType() == typeof(Card));
        }

        [Test]
        public void TestDeckIfGetNextCardReturnsNull()
        {
            Deck deck = new Deck();
            Assert.IsNotNull(deck.GetNextCard());
        }

        [Test]
        public void TestDeckIfGetNextCardRemoveCardProperly()
        {
            Deck deck = new Deck();
            deck.GetNextCard();
            Assert.AreEqual(23, deck.CardsLeft);
        }

        [Test]
        public void TestDeckIfTrumpCardIsCorrect()
        {
            Deck deck = new Deck();
            Assert.IsTrue(deck.GetTrumpCard.GetType() == typeof(Card));
        }

        [Test]
        public void TestDeckIfChangeTrumpCard()
        {
            Deck deck = new Deck();
            Card trumpCard = deck.GetTrumpCard;
            deck.ChangeTrumpCard(deck.GetNextCard());
            Assert.AreNotSame(trumpCard, deck.GetTrumpCard);
        }
    }
}
