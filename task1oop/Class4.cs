using System;
using System.Collections.Generic;
using System.Text;

namespace task1oop
{
    internal class Cinema
    {
        private Ticket[] tickets = new Ticket[20];

        public Ticket this[int index]
        {
            get
            {
                if (index > tickets.Length || index < 0)
                    return null;
                return tickets[index];
            }
            set
            {
                if (index < tickets.Length && index >= 0)
                    tickets[index] = value;
            }
        }

        public int this[string moveiname]
        {
            get
            {
                foreach (var item in tickets)
                {
                    if (item.MoveiName == moveiname)
                        return item.TicketId;

                }
                return 0;
            }

        }
       

        public  bool  AddTicket(Ticket t)
        {
            for (int i = 0; i < tickets.Length ; i++)
            {
                if (tickets[i] == null)
                {
                    tickets[i] = t;
                    return true;
                }

            }
            return false;
        }
    }
}