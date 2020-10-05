using System;
using System.Collections.Generic;
using System.Text;

namespace DinnerParty
{
    class BirthdayParty : Party
    {
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

        override public decimal Cost
        {
            get
            {
                decimal totalCost = base.Cost;
                decimal cakeCost = CakeSize() == 8
                    ? 40M + ActualLength * .25M
                    : 75M + ActualLength * .25M;
                return totalCost + cakeCost;
            }
        }
    }
}
