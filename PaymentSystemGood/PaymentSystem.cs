using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystemGood
{
    public class PaymentSystem
    {
        private IPaymentType _paymentType;

        public PaymentSystem(IPaymentType paymentType)
        {
            this._paymentType = paymentType;
        }

        public void Payment()
        {
            this._paymentType.Payment();
        }
    }
}
