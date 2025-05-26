using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Hemtenta_cinema
{
	/// <summary>
	/// Klass som kan bestämma seats samt sätta en selection.
	/// </summary>
	internal class Seat
    {
        //håller reda på om stolen är upptagen, index är stolens "nummer".
        public Boolean occupied = false;
        public int index;

        //när en seat skapas får den ett "nummer", detta skapas i Row
        public Seat(int index)
        {
            this.index = index;
        }

        // a selection av seats, klass i seats för man ska veta att det är en selection av seats (seats.selection)
        public class Selection
        {
            public List<Seat> seats; //en lista med stolar
            public int row; // vilken rad stolarna är på

			// Kopierar stolarna till en ny lista så att den inte delar referenser med andra grupper av stolar
			public Selection(List<Seat> seats, int row) 
			{
				this.seats = new List<Seat>(seats); 
				this.row = row;
			}
			public override string ToString()
			{
                // add +1 because index starts at 0 so seat #0 displays as seat 1
                int rowIndex = row + 1; //radens nummer
                int firstSeatIndex = seats[0].index + 1; //första stolens nummer
				int lastSeatIndex = seats[seats.Count - 1].index + 1; //sista stolens nummer

                //returnerar seat eller seats beroende på hur många det är
				if (seats.Count > 1)
                {
                    return "Row " + rowIndex + " Seats " + firstSeatIndex + "-" + lastSeatIndex;
				} else
                {
                    return "Row " + rowIndex + " Seat " + firstSeatIndex;
                }
			}
		}
    }
}
