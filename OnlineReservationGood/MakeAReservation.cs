using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineReservationGood
{
    public class MakeAReservation
    {
        private Reservation reservation;
        public Reservation MakeReservation()
        {
            reservation = new Reservation();
            return reservation;
        }
    }
}
