using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationSystemGood.VerifyTypes
{
    public class CouponConfirm : ICouponReservation
    {
        public int CouponNo { get; set; }

        public string GetHotelInformation()
        {
            throw new NotImplementedException();
        }

        public string GetUserName()
        {
            throw new NotImplementedException();
        }

        public bool PaymentWithCoupon()
        {
            throw new NotImplementedException();
        }

        public void VerifyBooking()
        {
            throw new NotImplementedException();
        }
    }
}
