using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Hemtenta_cinema
{
    /// <summary>
    /// Klass som håller i en seats lista
    /// </summary>
    internal class Row
    {
        //lista med stolar på en rad (variabel)
        public List<Seat> Seats = new List<Seat>();

        //skapar 15 stolar på en rad 
        public Row() {
            for (int i = 0; i < 15; i++) {
                Seats.Add(new Seat(i)); //lägger till en stol med nummer i 
                /*
                 För varje Seat lägger man också nummert i index variabeln när en new Seat skapas..
                 */
            }

        }
    }

}
