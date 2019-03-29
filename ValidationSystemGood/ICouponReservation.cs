using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationSystemGood
{
    public interface ICouponReservation : IFreeConfirmReservation
    {
        int CouponNo { get; set; }
        bool PaymentWithCoupon();
    }
}
