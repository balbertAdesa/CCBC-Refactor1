using System;
using System.Collections.Generic;
using System.Text;

namespace CCBC_Refactor1
{
    public class Class1
    {
        // This should calculate a discount for a shopper buying something
        // from our online store
        public decimal Calculate(decimal amount, int type, int years)
        {
            
            decimal result = 0;  // we'll store the result here
            decimal disc = (years > 5) ? (decimal)5 / 100 : (decimal)years / 100;



            ///////////   Actions  ////////////////
            // figure out what type of customer it is and calculate the discount
            if (type == 1)
            {
                // NO DISCOUTN FOR YOU!!
                result = amount;
            }
            else if (type == 2)
            {
                // This type should get a 20% discount
                result = (amount - (0.1m * amount)) - disc * (amount - (0.1m * amount));
            }
            else if (type == 3)
            {

                    result = (0.7m * amount) - disc * (0.7m * amount);
            }

            else 
            if (type == 4)
            {
                result = (amount - (0.5m * amount)) - disc * (amount - (0.5m * amount));
                //result = (amount - (0.5m * amount));
            }

            // ok, got it! return the result
            return result;
        }
    }
}
