namespace Poker
{
    using System;
    using System.Linq;

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
                for (int j = i + 1; j < ValidCardCount; j++)
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
            if (!this.IsValidHand(hand))
            {
                return false;
            }

            var firstCardSuit = hand.Cards[0].Suit;
            for (int i = 1; i < ValidCardCount; i++)
            {
                if (firstCardSuit != hand.Cards[i].Suit)
                {
                    return false;
                }
            }

            int[] arrayFacesInHand = new int[5];

            for (int i = 0; i < 5; i++)
            {
                arrayFacesInHand[i] = (int)hand.Cards[i].Face;
            }

            Array.Sort(arrayFacesInHand);

            if (arrayFacesInHand[0] == 2 &&
                arrayFacesInHand[1] == 3 &&
                arrayFacesInHand[2] == 4 &&
                arrayFacesInHand[3] == 5 &&
                arrayFacesInHand[4] == 14)
            {
                return true;
            }

            for (int i = 1; i < 5; i++)
            {
                if (Math.Abs(arrayFacesInHand[i] - arrayFacesInHand[i - 1]) != 1)
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsFourOfAKind(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                return false;
            }

            for (int i = 0; i < ValidCardCount; i++)
            {
                int count = 0;
                for (int j = 0; j < ValidCardCount; j++)
                {
                    if (hand.Cards[i].Face == hand.Cards[j].Face)
                    {
                        count++;
                    }

                    if (count == 4)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool IsFullHouse(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFlush(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                return false;
            }

            var firstCardSuit = hand.Cards[0].Suit;
            for (int i = 1; i < ValidCardCount; i++)
            {
                if (firstCardSuit != hand.Cards[i].Suit)
                {
                    return false;
                }
            }

            if (this.IsStraightFlush(hand))
            {
                return false;
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
