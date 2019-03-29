using OnlineReservationGoodDI.Entities;
using OnlineReservationGoodDI.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineReservationGoodDI.Vendors
{
    public class Vendor2 : IVendor
    {
        public List<Hotel> FindHotel(string city, DateTime startDate, DateTime endDate, int numberOfPeople)
        {
            return new List<Hotel>();
        }
    }
}
