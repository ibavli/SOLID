using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationSystemGood.VerifyTypes
{
    public class CreditCardConfirm : ICreditCardConfirmReservation
    {
        public string CreditCard { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string GetHotelInformation()
        {
            throw new NotImplementedException();
        }

        public string GetUserName()
        {
            throw new NotImplementedException();
        }

        public bool PaymentCreditCard()
        {
            throw new NotImplementedException();
        }

        public void VerifyBooking()
        {
            throw new NotImplementedException();
        }
    }
}
