using System;
using System.Collections.Generic;
using System.Text;

namespace DinnerParty
{
    class DinnerParty : Party
    {
        public bool HealthyOption { get; set; }

        public DinnerParty(int numberOfPeople, bool healthyOptions, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            HealthyOption = healthyOptions;
        }

        private decimal CalculateCostOfBeveragesPerPerson()
        {
            return HealthyOption ? 5.00M : 20.00M;
        }

        override public decimal Cost
        {
            get {
                decimal totalCost = base.Cost + NumberOfPeople * CalculateCostOfBeveragesPerPerson();
                return totalCost * (HealthyOption ? 0.95M : 1M);
            }
        }
    }
}
