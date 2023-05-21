using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSetProperty
{
    public class ThalapakattyBriyani
    {
        public HotelProperty HotelDetails()
        {
            var details = new HotelProperty()
            {
                HotelID = 2,
                HotelName = "Thalapakatty Briyani",
                ContactNo = 984569121,
                Address = "Taramani",
                Price = 280
            };
            return details;
        }
    }
}
