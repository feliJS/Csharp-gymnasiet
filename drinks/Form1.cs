using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _1_Hemtenta_drinks
{
    //huvudklass för design
    public partial class Form1 : Form
    {
        //ny order klass, ny soda och button selectedbutton för sodabutton_click
        public Order order = new Order();
        public Soda soda;
        public Button selectedButton;

        public Form1()
        {
            InitializeComponent();
        }

        //Hanterar klick på läsk-knappar och ändrar färg beroende på vilket knapp du clickar (Source: stack overflow, chatgpt och w3schools)
        public void SodaButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            if (selectedButton != null)
            {
                selectedButton.BackColor = System.Drawing.Color.SkyBlue;
            }
            selectedButton = clickedButton;
            selectedButton.BackColor = System.Drawing.Color.Blue;
        }

        //Metoder för varje läskknapp som skapar en läsk utifrån objekten i klassen och checkar också showhideFanta() metoden
        //De skapas endast, läggs inte direkt in i en ny order()
        private void colaBt_Click(object sender, EventArgs e)
        {
            soda = new Soda.CocaCola();
            showhideFanta();
        }

        private void pepsiBt_Click(object sender, EventArgs e)
        {
            soda = new Soda.Pepsi();
            showhideFanta();
        }

        private void SpriteBt_Click(object sender, EventArgs e)
        {
            soda = new Soda.Sprite();
            showhideFanta();
        }
        private void fantaBt_Click(object sender, EventArgs e)
        {
            soda = new Soda.Fanta();
            showhideFanta();
        }

        private void upBt_Click(object sender, EventArgs e)
        {
            soda = new Soda.SevenUp();
            showhideFanta();
        }


        private void DrPepperBt_Click(object sender, EventArgs e)
        {
            soda = new Soda.DrPepper();
            showhideFanta();
        }

        //hanterar val av smak för fanta
        private void fantaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // säger till visual studio att soda är Fanta så att FantaChoice visas
            ((Soda.Fanta) soda).FantaChoice(fantaComboBox.SelectedItem.ToString());
        }

		// Visar eller döljer alternativ beroende på vilken läsk som är vald
		private void showhideFanta()
        {
            //om man selectat en soda (inte är null, endast klickat på en knapp så en soda har skapats)
            if(soda != null)
            {
                //kan man se resten av valen man kan göra (size)
                label2.Visible = true;
                sizeComboBox.Visible = true;
            } else {
                label2.Visible = false;
                sizeComboBox.Visible = false;
            }
            //om soda har satts till fanta så kan man göra fanta valen

            if(soda is Soda.Fanta)
            {
                fantaComboBox.Visible = true;
                optFantaBt.Visible = true;
                opt2FantaBt.Visible = true;
            } else
            {
                fantaComboBox.Visible = false;
                optFantaBt.Visible = false;
                opt2FantaBt.Visible = false;
            }
        }

		// Bekräftar beställning av vald läsk och uppdaterar kvittot
		private void confirmBt_Click(object sender, EventArgs e)
        {
            /*
             Order lägger till soda i dens lista som man har klickat confirm på
            soda sätts till null
            showhidefanta() används
            confirmBt sätts till false
            Man uppdaterar kvittot
             */
            order.addSoda(soda);
            soda = null;
            showhideFanta();
            confirmBt.Visible = false;
            updateReceipt();
        }

        //updatera kvittot, med metoden getReceipt() i klassen order
        private void updateReceipt()
        {
            receiptLabel.Text = order.getReceipt();
        }

		// Hanterar val av storlek för läsk
		private void sizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            confirmBt.Visible = true;
            soda.setSize(sizeComboBox.SelectedItem.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sizeLabel_Click(object sender, EventArgs e)
        {

        }

		// Hanterar val av sockertyp för Fanta (på samma sätt som förra valet)
		private void optFantaBt_Click(object sender, EventArgs e)
        {
            ((Soda.Fanta)soda).SugarChoice("Sweeteners");
        }

        private void opt2FantaBt_Click(object sender, EventArgs e)
        {
            ((Soda.Fanta)soda).SugarChoice("Sugar");
        }

        private void buyBt_Click(object sender, EventArgs e)
        {
        }
    }
}
