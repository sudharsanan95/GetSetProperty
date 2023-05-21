using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSetProperty
{
    public class SSBriyani
    {
        public HotelProperty HotelDetails()
        {
            var details = new HotelProperty()
            {
               HotelID=1, HotelName="SSBriyani", ContactNo=945681161, Address="velachery", Price=180
            };
            return details;
        }
    }
}
