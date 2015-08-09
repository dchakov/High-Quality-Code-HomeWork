using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Poker.Test
{
    [TestClass]
    public class PokerHandsCheckerTest
    {
        private static Hand StraitFlush = new Hand(new List<ICard>()
            {
                new Card(CardFace.Jack,CardSuit.Spades),
                new Card(CardFace.Ten,CardSuit.Spades),
                new Card(CardFace.Nine,CardSuit.Spades),
                new Card(CardFace.Eight,CardSuit.Spades),
                new Card(CardFace.Seven,CardSuit.Spades)
            });

        private static Hand Flush = new Hand(new List<ICard>()
            {
                new Card(CardFace.Three,CardSuit.Spades),
                new Card(CardFace.Ten,CardSuit.Spades),
                new Card(CardFace.Nine,CardSuit.Spades),
                new Card(CardFace.Queen,CardSuit.Spades),
                new Card(CardFace.Seven,CardSuit.Spades)
            });

        private static Hand ValidHand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Queen,CardSuit.Clubs),
                new Card(CardFace.Two,CardSuit.Spades),
                new Card(CardFace.King,CardSuit.Hearts),
                new Card(CardFace.Eight,CardSuit.Clubs),
                new Card(CardFace.Three,CardSuit.Spades)
            });

        private static Hand InvalidHandWithEqualCards = new Hand(new List<ICard>()
            {
                new Card(CardFace.Three,CardSuit.Spades),
                new Card(CardFace.Three,CardSuit.Spades),
                new Card(CardFace.Nine,CardSuit.Spades),
                new Card(CardFace.Queen,CardSuit.Spades),
                new Card(CardFace.Seven,CardSuit.Spades)
            });

        private static Hand InvalidHandWithSixCards = new Hand(new List<ICard>()
            {
                new Card(CardFace.Three,CardSuit.Spades),
                new Card(CardFace.Three,CardSuit.Spades),
                new Card(CardFace.Nine,CardSuit.Spades),
                new Card(CardFace.Queen,CardSuit.Spades),
                new Card(CardFace.Seven,CardSuit.Spades),
                new Card(CardFace.King,CardSuit.Spades)
            });

        private static Hand InvalidHandWithFourCards = new Hand(new List<ICard>()
            {
                new Card(CardFace.Three,CardSuit.Spades),
                new Card(CardFace.Three,CardSuit.Spades),
                new Card(CardFace.Nine,CardSuit.Spades),
                new Card(CardFace.Queen,CardSuit.Spades)
            });

        // isValid tests
        [TestMethod]
        public void PokerHandsShouldReturnTrueIfIsValidHand()
        {
            PokerHandsChecker pokerChecker = new PokerHandsChecker();
            Assert.IsTrue(pokerChecker.IsValidHand(ValidHand));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void PokerHandsShouldThrowIfHandContainsLessThanFiveCards()
        {
            PokerHandsChecker pokerChecker = new PokerHandsChecker();
            pokerChecker.IsValidHand(InvalidHandWithFourCards);
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void PokerHandsShouldThrowIfHandContainsMoreThanFiveCards()
        {
            PokerHandsChecker pokerChecker = new PokerHandsChecker();
            pokerChecker.IsValidHand(InvalidHandWithSixCards);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void PokerHandsShouldThrowIfHandContainsEqualCards()
        {
            PokerHandsChecker pokerChecker = new PokerHandsChecker();
            pokerChecker.IsValidHand(InvalidHandWithEqualCards);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void PokerHandsShouldThrowWhenNullIsPassed()
        {
            PokerHandsChecker pokerChecker = new PokerHandsChecker();
            IHand hand = null;
            pokerChecker.IsValidHand(hand);
        }

        // isFlush test
        [TestMethod]
        public void PokerHandsShouldReturnTrueIfIs_FlushHand()
        {
            PokerHandsChecker pokerChecker = new PokerHandsChecker();
            Assert.IsTrue(pokerChecker.IsFlush(Flush));
        }

        [TestMethod]
        public void PokerHandsShouldReturnFalseIfItIsNot_FlushHand()
        {
            PokerHandsChecker pokerChecker = new PokerHandsChecker();
            Assert.IsFalse(pokerChecker.IsFlush(ValidHand));
        }

        [TestMethod]
        public void PokerHandsShouldReturnFalseIfIsInvalidInput_FlushHand()
        {
            PokerHandsChecker pokerChecker = new PokerHandsChecker();
            Assert.IsFalse(pokerChecker.IsFlush(InvalidHandWithEqualCards));
            Assert.IsFalse(pokerChecker.IsFlush(InvalidHandWithSixCards));
            Assert.IsFalse(pokerChecker.IsFlush(InvalidHandWithFourCards));
        }

        [TestMethod]
        public void PokerHandsShouldReturnFalseIfIs_FlushHand_ButIs_StaithFlushHand()
        {
            PokerHandsChecker pokerChecker = new PokerHandsChecker();
            Assert.IsFalse(pokerChecker.IsFlush(StraitFlush));
        }
    }
}
