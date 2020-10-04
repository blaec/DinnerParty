using System;
using System.Collections.Generic;
using System.Text;

namespace DinnerParty
{
    class DinnerParty
    {
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public bool HealthyOption { get; set; }

        public DinnerParty(int numberOfPeople, bool healthyOptions, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            HealthyOption = healthyOptions;
        }

        public const int COST_OF_FOOD_PER_PERSON = 25;

        private decimal CalculateCostOfBeveragesPerPerson()
        {
            return HealthyOption ? 5.00M : 20.00M;
        }

        private decimal CalculateCostOfDecorations()
        {
            return FancyDecorations
                ? (NumberOfPeople * 15.00M) + 50.00M
                : (NumberOfPeople * 7.50M) + 30.00M;
        }

        public decimal Cost
        {
            get {
                decimal totalCost = NumberOfPeople * (COST_OF_FOOD_PER_PERSON + CalculateCostOfBeveragesPerPerson()) + CalculateCostOfDecorations();
                return totalCost * (HealthyOption ? 0.95M : 1M);
            }
        }
    }
}
