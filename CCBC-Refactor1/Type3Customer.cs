using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeBookClub.Refactor
{
    public class Type3Customer : BaseCustomer {
        public Type3Customer(int years)
        {
            base.years = years;
        }

        public override decimal Calculate(decimal amount)
        {
            return (0.7m * amount) - discount * (0.7m * amount);;
        }
    }
}
