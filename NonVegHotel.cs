using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GetSetProperty
{
    public class NonVegHotel
    {
        public List<object> Display(int HotelID)
        {
            var obj = new List<object>();
            switch (HotelID)
            {
                case 1:
                    var detail= new SSBriyani().HotelDetails();
                    Console.WriteLine("Your Requested Hotel Details:");
                    obj.Add(detail.HotelID);
                    obj.Add(detail.HotelName);
                    obj.Add(detail.ContactNo);
                    obj.Add(detail.Address);
                    obj.Add(detail.Price);
                    break;
                case 2:
                    var detail1 = new ThalapakattyBriyani().HotelDetails();
                    Console.WriteLine("Your Requested Hotel Details:");
                    obj.Add(detail1.HotelID);
                    obj.Add(detail1.HotelName);
                    obj.Add(detail1.ContactNo);
                    obj.Add(detail1.Address);
                    obj.Add(detail1.Price);
                    break;
                case 3:
                    var detail2 = new Buhari().HotelDetails();
                    Console.WriteLine("Your Requested Hotel Details:");
                    obj.Add(detail2.HotelID);
                    obj.Add(detail2.HotelName);
                    obj.Add(detail2.ContactNo);
                    obj.Add(detail2.Address);
                    obj.Add(detail2.Price);
                    break;
                default:
                    Console.WriteLine("No details found");
                    break;
            }
            return obj;
        }
    }
}
