using OnlineReservationGoodDI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineReservationGoodDI.Interface
{
    public interface IVendor
    {
        List<Hotel> FindHotel(string city, DateTime startDate, DateTime endDate, int numberOfPeople);
    }
}
