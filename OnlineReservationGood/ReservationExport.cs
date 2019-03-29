using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineReservationGood
{
    public class ReservationExport
    {
        private List<Reservation> reservations;
        public void Export()
        {
            //get reservations (from db)
            reservations = new List<Reservation>();
        }
    }
}
