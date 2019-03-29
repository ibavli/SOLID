using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationSystemGood
{
    public interface IFreeConfirmReservation
    {
        string GetUserName();
        string GetHotelInformation();

        void VerifyBooking();
    }
}
