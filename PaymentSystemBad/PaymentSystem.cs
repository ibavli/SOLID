using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystemBad
{
    public class PaymentSystem
    {
        private CreditCard creditCard;
        private PaymentRemittance paymentRemittance;
        private PayAtDoor payAtDoor;

        public PaymentSystem()
        {
            creditCard = new CreditCard();
            paymentRemittance = new PaymentRemittance();
            payAtDoor = new PayAtDoor();
        }

        public void Payment(int paymentType)
        {
            if (paymentType == 1)
                PaymentCreditCart();
            else if (paymentType == 2)
                PaymentRemittance();
            else if (paymentType == 3)
                PayAtDoor();
            else
                throw new ApplicationException("Not found.");
        }

        private string PaymentCreditCart()
        {
            return creditCard.Payment();
        }

        private string PaymentRemittance()
        {
            return paymentRemittance.Payment();
        }

        private string PayAtDoor()
        {
            return payAtDoor.Payment();
        }

    }
}
