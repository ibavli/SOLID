using OnlineReservationGoodDI.Entities;
using OnlineReservationGoodDI.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineReservationGoodDI
{
    public class FindHotel
    {
        private List<IVendor> _vendor;

        public FindHotel(List<IVendor> vendors)
        {
            this._vendor = vendors;
        }

        List<Hotel> hotels;
        public List<Hotel> FindHotelMethod(string city, DateTime startDate, DateTime endDate, int numberOfPeople)
        {
            hotels = new List<Hotel>();

            foreach (var vendor in _vendor)
            {
                hotels.AddRange(vendor.FindHotel(city, startDate, endDate, numberOfPeople));
            }


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
