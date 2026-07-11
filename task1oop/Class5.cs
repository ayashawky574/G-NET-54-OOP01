using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Text;

namespace task1oop
{
    internal static class BookingHelper
    {
        private static int _counter=0;
        public static double CalcGroupDiscount(int numberOfTickets, double pricePerTicket)
        {
            double price = numberOfTickets * pricePerTicket;
            if (numberOfTickets >= 5)
                return price-price * 0.10;

            return price;
        }
        
        public static string GenerateBookingReference()
        {
            _counter++;
            return $"BK-{_counter}";
        }
    
    }
}
