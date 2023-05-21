using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSetProperty
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var input = Convert.ToInt32(Console.ReadLine());
            var customer = new NonVegHotel().Display(input);
            foreach ( var item in customer)
           {
                Console.WriteLine(item);
            }
        }
    }
}
