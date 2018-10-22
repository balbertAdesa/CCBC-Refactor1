using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeBookClub.Refactor
{
    public class DefaultCustomer : BaseCustomer {
        public DefaultCustomer(int years)
        {
            base.years = years;
        }
    }
}