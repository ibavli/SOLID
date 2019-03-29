using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationSystemBad
{
    public class Reservation : IReservation
    {
        public string GetUserName()
        {
            return "User Name";
        }

        public string GetHotelInformation()
        {
            return "Hotel Information";
        }

        public string CreditCardNumbeer { get; set; }

        public bool PaymentCreditCard()
        {
            //Payment credit card
            return true;//response from the bank service
        }

        public int Coupon { get; set; }

        public bool PaymentCoupon()
        {
            //payment with coupon
            return true;
        }

        private int validationOptions;
        public void VerifyBooking()
        {
            if (validationOptions == 1)
            {
                //TODO
            }
            else if (validationOptions == 2)
            {
                bool result = PaymentCreditCard();
                if (result)
                {
                    //TODO
                }
            }
            else if (validationOptions == 3)
            {
                bool result = PaymentCoupon();
                if (result)
                {
                    //TODO
                }
            }

        }
    }
}
