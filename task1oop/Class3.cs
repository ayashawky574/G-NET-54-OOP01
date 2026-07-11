using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace task1oop
{
    internal class Ticket
    {
        private string _moveiName;
        public TicketType Type { get; set; }
        public SeatLocation Seat { get; set; }
        private double _price;
        private static int _ticketCounter =0 ;

        public int TicketId
        {
            get; private set;
        }
       public string MoveiName { 
            get => _moveiName;
            set { if (string.IsNullOrWhiteSpace(value))
                    return;
                _moveiName = value;
 }
        }
        public double Price {
            get => _price;
            set
            {
                if (value <= 0)
                    return;
                _price = value;
            }
        }

        public static int GetTotalTicketsSold() => _ticketCounter;
        
        public Ticket(string moveiname, TicketType type, SeatLocation seat, double price)
        {
            MoveiName = moveiname;
            Type = type;
            Seat = seat;
            Price = price;
            _ticketCounter++;
            TicketId = _ticketCounter;

        }
        public Ticket(string moveiname) 
            : this(moveiname ,TicketType.Standard , new SeatLocation('A',1) ,50)
         {
          
        }

        public double PriceAfterTax
        {
            get {
                double taxAmount = Price * 14 / 100;
                return Price + taxAmount;
            }
            
        }

        public override string ToString()
        {
            return $"{_moveiName} | {Type} |seat : {Seat} |price : {_price} EGP | AfterTax : {PriceAfterTax} EGP";
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
Total (14% Tax) : {PriceAfterTax}");

            
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
