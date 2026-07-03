using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace task1oop
{
    internal class Ticket
    {
        public string MoveiName { get; set; }
        public TicketType Type { get; set; }
        public SeatLocation Seat { get; set; }
        private double Price;

       
        public Ticket(string moveiname, TicketType type, SeatLocation seat, double price)
        {
            MoveiName = moveiname;
            Type = type;
            Seat = seat;
            Price = price;
        }
        public Ticket(string moveiname) 
            : this(moveiname ,TicketType.Standard , new SeatLocation('A',1) ,50)
         {
          
        }

        public double CalcTotal(double taxPercent)
        {
            double taxAmount = Price * taxPercent / 100;
            return Price + taxAmount;
        }
         public void ApplyDiscount(ref double discountAmount)
        {
            double beforeDiscount = discountAmount;
            if (discountAmount>0 && discountAmount<=Price)
            {
                Price = Price - discountAmount;
                discountAmount = 0;
            }
            Console.WriteLine($@"==== After Discount ====
before Discount      :{beforeDiscount}
ِAfter Discount      : {discountAmount}
Prcie                : {Price}
Total (14% Tax) : {CalcTotal(14)}");

            
        }
        public void PrintTicket()
        {
            Console.WriteLine($@"==== Ticket Info ====
Movie   : {MoveiName}
Type    : {Type}
Seat    : {Seat}
Price   : {Price}


                                 ");
           
        }
    }
}
