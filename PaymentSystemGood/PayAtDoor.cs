using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystemGood
{
    public class PayAtDoor : IPaymentType
    {
        public string Payment()
        {
            return "Pay At Door";
        }
    }
}
