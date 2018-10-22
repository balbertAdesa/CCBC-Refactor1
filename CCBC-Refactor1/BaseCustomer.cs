using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeBookClub.Refactor
{
    public abstract class BaseCustomer {

        public int years { get; set;}

        protected decimal discount 
        {
            get
            {
                return (years > 5) ? (decimal)5 / 100 : (decimal)years / 100;
            }
        }

        public virtual decimal Calculate(decimal amount)
        {
            return amount;
        }
    }
}
