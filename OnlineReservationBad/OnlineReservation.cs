using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineReservationBad
{
    public class OnlineReservation
    {
        public List<Hotel> FindHotel(string city, DateTime startDate, DateTime endDate, int numberOfPeople)
        {
            List<Hotel> result = new List<Hotel>();
            result.AddRange(Vendor1FindHotel(city, startDate, endDate, numberOfPeople));
            result.AddRange(Vendor2FindHotel(city, startDate, endDate, numberOfPeople));
            result = result.GroupBy(i => i.HotelName).Select(i => new Hotel //Get the cheapest
            {
                HotelName = i.Key,
                Price = i.Min(j => j.Price),
                VendorId = i.Min(j => j.VendorId)
            }).ToList();
            return result;
        }

        private List<Hotel> Vendor1FindHotel(string city, DateTime startDate, DateTime endDate, int numberOfPeople)
        {
            //get list (web service)
            return new List<Hotel>();
        }

        private List<Hotel> Vendor2FindHotel(string city, DateTime startDate, DateTime endDate, int numberOfPeople)
        {
            //get list (web service)
            return new List<Hotel>();
        }

        public bool MakeAReservation(Hotel hotel, DateTime startDate, DateTime endDate, int numberOfPeople)
        {
            return true;
        }

        public void ExportExcel()
        {
            //get hotel list (from db)
            //export excel
        }
    }
}
