using System;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        public const int ValidCardCount = 5;

        public bool IsValidHand(IHand hand)
        {
            if (hand == null)
            {
                throw new ArgumentNullException("Null is passed");
            }

            if (hand.Cards.Count != ValidCardCount)
            {
                throw new ArgumentException("Invalid hand");
            }

            for (int i = 0; i < ValidCardCount - 1; i++)
            {
                for (int j = i+1; j < ValidCardCount; j++)
                {
                    if (hand.Cards[i].ToString() == hand.Cards[j].ToString())
                    {
                        throw new ArgumentException("Equal cards");
                    }
                }
            }

            return true;
        }

        public bool IsStraightFlush(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFourOfAKind(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFullHouse(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFlush(IHand hand)
        {
            for (int i = 0; i < ValidCardCount; i++)
            {
                
            }
            return true;
        }

        public bool IsStraight(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsTwoPair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsOnePair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsHighCard(IHand hand)
        {
            throw new NotImplementedException();
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }
    }
}
