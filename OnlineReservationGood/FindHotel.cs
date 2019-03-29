using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineReservationGood
{
    public class FindHotel
    {
        Vendor1 vendor1 = new Vendor1();
        Vendor2 vendor2 = new Vendor2();
        List<Hotel> hotels;
        public List<Hotel> FindHotelMethod(string city, DateTime startDate, DateTime endDate, int numberOfPeople)
        {
            hotels = new List<Hotel>();
            hotels.AddRange(vendor1.FindHotel(city, startDate, endDate, numberOfPeople));
            hotels.AddRange(vendor2.FindHotel(city, startDate, endDate, numberOfPeople));
            hotels = hotels.GroupBy(i => i.HotelName).Select(i => new Hotel //Get the cheapest
            {
                HotelName = i.Key,
                Price = i.Min(j => j.Price),
                VendorId = i.Min(j => j.VendorId)
            }).ToList();
            return hotels;
        }
    }
}
