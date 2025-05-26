using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_Hemtenta_cinema
{
    public partial class Form1 : Form
	{
		private Movie selectedMovie; // Den valda filmen
		private int peopleCount; // Antalet personer

        //Selectedrowindex lagrar bara int av select row, medans selectedrow lagrar självaste raden!
		private int selectedRowIndex; // Den valda radens index
		private Row selectedRow; // Den valda raden
		private Seat.Selection selectedSeats; // De valda stolarna
		private Label[] seatDisplays; // Etiketter som visar stolarna
		public Form1()
        {
            InitializeComponent();

            // alla olika seat labels
            seatDisplays = new Label[] { seat1, seat2, seat3, seat4, seat5, seat6, seat7, seat8, seat9, seat10, seat11, seat12, seat13, seat14, seat15 };

            //sätter moviecomobox itemserna här istället så man kan direkt välja index 0, vilket gör att första filmen blir default option
            //sätter också de andra comboboxerna default till index 0
            movieComboBox.Items.Add(new Movie.FallGuy());
            movieComboBox.Items.Add(new Movie.BoyKillsWorld());
            movieComboBox.SelectedIndex = 0;
			rowComboBox.SelectedIndex = 0;
			peopleCountComboBox.SelectedIndex = 0;
		}

        private void peopleCountComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //sätter hur många du har valt till en int
            peopleCount = Int32.Parse(peopleCountComboBox.SelectedItem.ToString());
            //om selectedRow inte är null, alltså om du har valt en row... updateSeatsComboBox()
            if (selectedRow != null)
            {
                updateSeatsComboBox();
            }
        }


        private void rowComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //sätter det du har selectat till en int som metoden selectRow använder som selectedrowIndex
            selectRow(Int32.Parse(rowComboBox.SelectedItem.ToString()) - 1);
            //displayar 
            radShowing.Text = "Displaying: " + rowComboBox.SelectedItem.ToString();

        }

        private void seatsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Lägger den du har selectat som selectedSeats
            selectedSeats = (Seat.Selection)seatsComboBox.SelectedItem;
            updateDisplay();
        }

        private void bookBtn_Click(object sender, EventArgs e)
        {
            error(""); // clearar error med empty meddelande
            if(peopleCount == -1) // peopleCount is -1 by default (look top of code) so if its -1 here it means it never changed
            {
                error("Please select how many people to book.");
                return;
            }
            if(selectedRow == null) // if selectedRow is null it hasnt been selected yet
            {
                error("Please select a row.");
                return;
            }
            if(selectedSeats == null || selectedSeats.seats.Count == 0)
            {
                error("Please select a seat");
                return;
            }

            foreach (Seat seat in selectedSeats.seats)
            {
                seat.occupied = true;
            }
            updateDisplay();
            updateSeatsComboBox();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
          
        }

        //error label, uppdaterar en label
        private void error(string errorMessage)
        {
            errorLabel.Text = errorMessage;
        }

        private void updateDisplay()
        {
            //for loop för att bestämma färger
            for (int i = 0; i < 15; i++)
            {
                //för varje seat kollar den
                Seat seat = selectedRow.Seats[i];
                Label seatLabel = seatDisplays[i];
                //om occupied brown
                if(seat.occupied)
                {
                    seatLabel.BackColor = System.Drawing.Color.Brown;
                } else
                //annars vanlig färg
                {
                    seatLabel.BackColor = System.Drawing.SystemColors.Info;
                    //om selectedSeats inte är null
                    if(selectedSeats != null)
                    {
                        //om selectedSeats.seats har någon seat
						if (selectedSeats.seats.Contains(seat))
						{
                            //visa denna som att den är "selectad"
							seatLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;

						}
					}
                }
            }
        }

        //uppdatera Seatscomboboxen
        private void updateSeatsComboBox()
        {
            //cleara den först på items
            seatsComboBox.Items.Clear();

            //skapa en ny lista med seats
            List<Seat> seatQueue = new List<Seat>();

            //loopar igenom 15 ggr
            for (int i = 0; i < 15; i++)
            {
                //hämta en specifik stol i rad listan
                Seat seat = selectedRow.Seats[i];

                //om seat är occupied
                if(seat.occupied)
                {
                    //cleara seatqueue listan
                    seatQueue.Clear();
                    continue; // fortsätt till nästa
                }
                //lägg till seat i listan som inte är occupied
                seatQueue.Add(seat);

                //om seatQueue har lika många platser som peopleCount, lägg till i seatsComboBox itemet
                //Detta är då en ny seat.Selection som tar både in listan seatQueue men också rowindex vilket är radens index (vilken rad det är)
          
                if(seatQueue.Count == peopleCount) 
                {
                    seatsComboBox.Items.Add(new Seat.Selection(seatQueue, selectedRowIndex));
                    seatQueue.RemoveAt(0);
                }
            }
        }

        //selectar row, tar in den man valt
        private void selectRow(int rowIndex)
        {
            selectedRowIndex = rowIndex;
            //i cinema klassen i movie klassen så tar man ut rows klassen och skaffar selectedrowindex
			selectedRow = selectedMovie.cinema.Rows[selectedRowIndex]; // get row from cinema. subtract 1 because combobox goes from 1-15 and programming index starts at 0
			updateDisplay();
		    updateSeatsComboBox();
		}

		private void movieComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
            //sätter movie
            selectedMovie = (Movie)movieComboBox.SelectedItem;
            titleLabel.Text = selectedMovie.name;
            descriptionLabel.Text = selectedMovie.description;
            movieImage.Image = selectedMovie.image;

            //resetA för det är en annan film
            selectedSeats = null;
            selectRow(selectedRowIndex);
		}

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }
        private void errorLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
