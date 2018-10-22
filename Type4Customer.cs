using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeBookClub.Refactor
{
    public class Type4Customer : BaseCustomer {
        public Type4Customer(int years)
        {
            base.years = years;
        }

        public override decimal Calculate(decimal amount)
        {
            return (amount - (0.5m * amount)) - discount * (amount - (0.5m * amount));
        }        
    }
}