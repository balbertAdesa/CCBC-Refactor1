using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeBookClub.Refactor
{
    public class Type2Customer : BaseCustomer {
        public Type2Customer(int years)
        {
            base.years = years;
        }

        public override decimal Calculate(decimal amount)
        {
            return (amount - (0.1m * amount)) - base.discount * (amount - (0.1m * amount));
        }
    }
}