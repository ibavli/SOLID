using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystemGood
{
    public class Test
    {
        public PaymentSystem paymentSystem;

        public Test(IPaymentType paymentType)
        {
            paymentSystem = new PaymentSystem(paymentType);
        }
    }
}
