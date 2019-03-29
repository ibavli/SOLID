using OnlineReservationGoodDI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineReservationGoodDI
{
    public class ReservationDAO
    {
        private Reservation reservation;
        public Reservation MakeAReservation()
        {
            //Save db
            reservation = new Reservation();
            return reservation;
        }

        public List<Reservation> GetReservations()
        {
            //Get Reservations from db
            return new List<Reservation>();
        }


    }
}
