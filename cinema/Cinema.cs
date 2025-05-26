using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Hemtenta_cinema
{
    /// <summary>
    /// Klass som har en lista med olika rows
    /// </summary>
    internal class Cinema
    {
        public List<Row> Rows = new List<Row>(); //en lista med rader

        public Cinema()
        {
            for (int i = 0; i < 10; i++) //skapar 10 rader
            {
                Rows.Add(new Row());
            }
        }
    }
}