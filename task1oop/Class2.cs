using System;
using System.Collections.Generic;
using System.Text;

namespace task1oop
{
    public struct SeatLocation
    {
        public char Row { get; set; }
        public int Number { get; set; }
        public override string ToString()
        {
            return $"{Row}{Number}";
        }
        public SeatLocation(char row , int number)
        {
            Row = row;
            Number = number;
        }
    }
}
