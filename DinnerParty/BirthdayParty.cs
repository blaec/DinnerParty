using System;
using System.Collections.Generic;
using System.Text;

namespace DinnerParty
{
    class BirthdayParty
    {
        public const int COST_OF_FOOD_PER_PERSON = 25;

        public int NumberOfPeople { get; set; }

        public bool FancyDecorations { get; set; }

        public string CakeWriting { get; set; }

        public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            CakeWriting = cakeWriting;
        }

        private int ActualLength
        {
            get
            {
                return CakeWriting.Length > MaxWritingLength()
                    ? MaxWritingLength()
                    : CakeWriting.Length;
            }
        }

        private int CakeSize()
        {
            return NumberOfPeople <= 4 ? 8 : 16;
        }

        private int MaxWritingLength()
        {
            return CakeSize() == 8 ? 16 : 40;
        }

        public bool CakeWritingTooLong
        {
            get { return CakeWriting.Length > MaxWritingLength(); }
        }

        private decimal CalculateCostOfDecorations()
        {
            return FancyDecorations
                ? (NumberOfPeople * 15.00M) + 50M
                : (NumberOfPeople * 7.50M) + 30M;
        }

        public decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations();
                totalCost += COST_OF_FOOD_PER_PERSON * NumberOfPeople;
                decimal cakeCost = CakeSize() == 8
                    ? 40M + ActualLength * .25M
                    : 75M + ActualLength * .25M;
                return totalCost + cakeCost;
            }
        }
    }
}
