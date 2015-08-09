namespace Poker.Test
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class PokerHandsCheckerTest
    {
        private static readonly Hand FourOfAKind = new Hand(new List<ICard>()
            {
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Seven, CardSuit.Spades)
            });

        private static readonly Hand StraitFlush = new Hand(new List<ICard>()
            {
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Eight, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Spades)
            });

        private static readonly Hand StraitFlushAceToFive = new Hand(new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Three, CardSuit.Spades),
                new Card(CardFace.Four, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Spades)
            });

        private static readonly Hand StraitFlushTenToAce = new Hand(new List<ICard>()
            {
                new Card(CardFace.Ten, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Hearts)
            });

        private static readonly Hand Flush = new Hand(new List<ICard>()
            {
                new Card(CardFace.Three, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Spades)
            });

        private static readonly Hand ValidHand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.Eight, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Spades)
            });

        private static readonly Hand InvalidHandWithEqualCards = new Hand(new List<ICard>()
            {
                new Card(CardFace.Three, CardSuit.Spades),
                new Card(CardFace.Three, CardSuit.Spades),
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Spades)
            });

        private static readonly Hand InvalidHandWithSixCards = new Hand(new List<ICard>()
            {
                new Card(CardFace.Three, CardSuit.Spades),
                new Card(CardFace.Three, CardSuit.Spades),
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Spades)
            });

        private static readonly Hand InvalidHandWithFourCards = new Hand(new List<ICard>()
            {
                new Card(CardFace.Three, CardSuit.Spades),
                new Card(CardFace.Three, CardSuit.Spades),
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Spades)
            });

        // IsValid tests
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

        // IsFlush test
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
        [ExpectedException(typeof(ArgumentException))]
        public void PokerHandsShouldReturnFalseIfIsInvalidInput_FlushHand()
        {
            PokerHandsChecker pokerChecker = new PokerHandsChecker();
            pokerChecker.IsFlush(InvalidHandWithEqualCards);
            pokerChecker.IsFlush(InvalidHandWithSixCards);
            pokerChecker.IsFlush(InvalidHandWithFourCards);
        }

        [TestMethod]
        public void PokerHandsShouldReturnFalseIfIs_FlushHand_ButIs_StaithFlushHand()
        {
            PokerHandsChecker pokerChecker = new PokerHandsChecker();
            Assert.IsFalse(pokerChecker.IsFlush(StraitFlush));
        }

        // IsStraithFlush test
        [TestMethod]
        public void PokerHandsShouldReturnTrueIfIs_StraightFlush()
        {
            PokerHandsChecker pokerChecker = new PokerHandsChecker();
            Assert.IsTrue(pokerChecker.IsStraightFlush(StraitFlush));
        }

        [TestMethod]
        public void PokerHandsShouldReturnFalseIfItIsNot_StraitFlush()
        {
            PokerHandsChecker pokerChecker = new PokerHandsChecker();
            Assert.IsFalse(pokerChecker.IsStraightFlush(ValidHand));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void PokerHandsShouldReturnFalseIfIsInvalidInput_StraitFlush()
        {
            PokerHandsChecker pokerChecker = new PokerHandsChecker();
            pokerChecker.IsStraightFlush(InvalidHandWithEqualCards);
            pokerChecker.IsStraightFlush(InvalidHandWithSixCards);
            pokerChecker.IsStraightFlush(InvalidHandWithFourCards);
        }

        [TestMethod]
        public void PokerHandsShouldReturnTrueAceToFive_StraightFlush()
        {
            PokerHandsChecker pokerChecker = new PokerHandsChecker();
            Assert.IsTrue(pokerChecker.IsStraightFlush(StraitFlushAceToFive));
        }

        [TestMethod]
        public void PokerHandsShouldReturnTrueTenToAce_StraightFlush()
        {
            PokerHandsChecker pokerChecker = new PokerHandsChecker();
            Assert.IsTrue(pokerChecker.IsStraightFlush(StraitFlushTenToAce));
        }

        // IsFourOfAKind
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void PokerHandsShouldReturnFalseIfIsInvalidInput_FourOfAKind()
        {
            PokerHandsChecker pokerChecker = new PokerHandsChecker();
            pokerChecker.IsFourOfAKind(InvalidHandWithEqualCards);
            pokerChecker.IsFourOfAKind(InvalidHandWithSixCards);
            pokerChecker.IsFourOfAKind(InvalidHandWithFourCards);
        }

        [TestMethod]
        public void PokerHandsShouldReturnTrueIfIs_FourOfAKind()
        {
            PokerHandsChecker pokerChecker = new PokerHandsChecker();
            Assert.IsTrue(pokerChecker.IsFourOfAKind(FourOfAKind));
        }

        [TestMethod]
        public void PokerHandsShouldReturnFalseIfItIsNot_FourOfAKind()
        {
            PokerHandsChecker pokerChecker = new PokerHandsChecker();
            Assert.IsFalse(pokerChecker.IsFourOfAKind(ValidHand));
        }
    }
}