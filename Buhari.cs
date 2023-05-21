using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSetProperty
{
    public class Buhari
    {
        public HotelProperty HotelDetails()
        {
            var details = new HotelProperty()
            {
                HotelID = 3,
                HotelName = "Buhari",
                ContactNo = 946981212,
                Address = "Tamabaram",
                Price = 210
            };
            return details;
        }
    }
}
