using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credit
{
    public class Shopper
    {
        private ICreditCard creditCard;

        public int ChargesForCreditCard { get { return creditCard.ChargeCount; } }

        public Shopper(ICreditCard creditCard)
        {
            this.creditCard = creditCard;
        }

        public string Charge()
        {
            return creditCard.Charge();
        }
    }
}
