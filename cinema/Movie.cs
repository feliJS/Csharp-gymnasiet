using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Hemtenta_cinema
{

	/// <summary>
	/// Movie klass som skapar en cinema och innehåller två subklasser för olika filmer
	/// </summary>
	internal class Movie
	{
		public Cinema cinema = new Cinema(); // En bio som hör till filmen
		public string name; // Filmens namn
		public string description; // Filmens beskrivning
		public System.Drawing.Bitmap image; // Filmens bild

		public override string ToString()
		{
			return this.name; // Returnerar filmens namn
		}

		public class FallGuy : Movie
		{
			public FallGuy()
			{
				this.name = "Fall Guy";
				this.description = "\"Fall Guy\" is an action-comedy film starring Ryan Gosling as Colt Seavers, a Hollywood stuntman who doubles as a bounty hunter. Directed by David Leitch, the movie combines thrilling stunts, humor, and drama as Colt navigates dangerous escapades both on and off the set.";
				this.image = Properties.Resources.stumble_guy;
			}
		}

		public class BoyKillsWorld : Movie
		{
			public BoyKillsWorld()
			{
				this.name = "Boy kills World";
				this.description = "\"Boy Kills World\" is a dystopian action-thriller following a deaf-mute warrior named Boy, portrayed by Bill Skarsgård. Trained in martial arts after the brutal murder of his family, Boy seeks vengeance in a surreal, nightmarish world. Directed by Moritz Mohr, the film blends intense action, dark humor, and a strikingly unique visual style.";
				this.image = Properties.Resources.boy_from_carbon_world;
			}
		}
	}
}
