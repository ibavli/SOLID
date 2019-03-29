using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationSystemBad
{
    public interface IReservation
    {
        string GetUserName();
        string GetHotelInformation();

        string CreditCardNumbeer { get; set; }
        bool PaymentCreditCard();

        int Coupon { get; set; }
        bool PaymentCoupon();

        void VerifyBooking();
    }
}
