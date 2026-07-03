namespace task1oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region q1
            //Class1 c1 = new Class1();
            //c1.Name = "Test";
            //Class1 c2 = c1;
            //c2.Name = "Test2";
            //Console.WriteLine(c1.Name);
            //Console.WriteLine(c2.Name);

            //Struct1 s1 = new Struct1();
            //s1.Name = "Test";
            //Struct1 s2 = s1;
            //s2.Name = "Test2";
            //Console.WriteLine(s1.Name);
            //Console.WriteLine(s2.Name);
            #endregion

            #region q2
            //Console.WriteLine(c1.Name);
            ////public modifier can be accessed every where
            //Console.WriteLine(c1.age);
            //private can be accessed only in class
            #endregion

            #region q3
            //1-create new project
            //2-class library
            //3- build 
            //4- add reference to the project we use library class in it
            #endregion

            #region q4
            // class library : is a collection of reusable classes compiled into a dll file
            ///reusability - organization- maintainance- teamwork
            #endregion

            #region part02
            Console.Write("Enter Movie Name : ");
            string moveiName = Console.ReadLine();
            TicketType type;
            while (true)
            {
            Console.Write("Enter Ticket Type (0=Standard , 1 = VIP , 2 = MAX): ");
                string input = Console.ReadLine();
                if (Enum.TryParse<TicketType>(input,out type) && Enum.IsDefined(typeof(TicketType), type))
                {
                    break;
                }
                Console.WriteLine("Invalid Type , try again.");
            }
            ;
            
            Console.Write("Enter Seat Row (A , B , C ,..) : ");
            char.TryParse( Console.ReadLine().ToUpper() , out char SeatRow);
            Console.Write("Enter Seat Number : ");
            int.TryParse(Console.ReadLine(), out int SeatNumber);
            SeatLocation seat = new SeatLocation(SeatRow , SeatNumber);
            Console.Write("Enter Price : ");
            double.TryParse(Console.ReadLine(), out double price);
            Console.Write("Enter discountAmount  : ");
            double.TryParse(Console.ReadLine(), out double discountAmount);

                Ticket ticket = new Ticket(moveiName, type, seat, price);
                ticket.PrintTicket();

            ticket.ApplyDiscount(ref discountAmount);




            #endregion
        }
    }
}
