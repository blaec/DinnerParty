using System;
using System.Collections.Generic;
using System.Text;

namespace DinnerParty
{
    class Party
    {
        public const int COST_OF_FOOD_PER_PERSON = 25;

        public int NumberOfPeople { get; set; }

        public bool FancyDecorations { get; set; }

        private decimal CalculateCostOfDecorations()
        {
            return FancyDecorations
                ? (NumberOfPeople * 15.00M) + 50.00M
                : (NumberOfPeople * 7.50M) + 30.00M;
        }

        virtual public decimal Cost
        {
            get
            {
                return CalculateCostOfDecorations() + 
                    COST_OF_FOOD_PER_PERSON * NumberOfPeople + 
                    (NumberOfPeople > 12 ? 100M : 0M);
            }
        }
    }
}
