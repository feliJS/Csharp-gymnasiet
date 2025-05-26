using System.Collections.Generic;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

/// <summary>
/// Klass som tar in namn och pris, sätter size och representerar olika sodas med egna namn.
/// </summary>


//klass som representerar en läsk
public class Soda
{
    //namn och pris på läsk (som sedan de andra ärver)
    public string Name;
    public int Price;

    //metod för att sätta storlek på läsken, därmed blir det också priset
    public void setSize(string size)
    {
        if (size == "4x4")
        {
            this.Price = 160;
        }
        else if (size == "6x4")
        {
            this.Price = 240;
        }
        else if (size == "6x6")
        {
            this.Price = 360;
        }
    }

    /*Metod för att att hämta namnet på läsken
     virtual så den kan overridea så man enklare kan få ut fanta choices
    */
    public virtual string getName()
    {
        return this.Name;
    }

    public class CocaCola : Soda
    {
        public CocaCola() {
            this.Name = "Coca Cola";
        }
    }
    //Objekt av Soda, ärver name och price, har egna attributer
    public class Pepsi : Soda
    {
        public Pepsi()
        {
            this.Name = "Pepsi";
        }
    }

    public class DrPepper : Soda
    {
        public DrPepper()
        {
            this.Name = "Dr pepper";
        }
    }

    public class Sprite : Soda
    {
        public Sprite()
        {
            this.Name = "Sprite";
        }
    }
    public class SevenUp : Soda
    {
        public SevenUp()
        {
            this.Name = "7up";
        }
    }

	//Fanta  speciell med extra egenskaper
	public class Fanta : Soda
    {
        //String fantaflavour och sugar
        public string fantaFlavour;
        public string sugar = "Sugar";

        public Fanta()
        {
            this.Name = "Fanta";
        }
        //metod för att välja smak på fantan
        public void FantaChoice(string flavour)
        {
            this.fantaFlavour = flavour;
        }
        //metod för socker typ på fantan
        public void SugarChoice(string sugar)
        {
            this.sugar = sugar;
        }

        // overrida getName från Soda så att den returnerar fanta information också
        public override string getName()
        {
            return this.Name + " (" + this.fantaFlavour + ", " + this.sugar + ")";
        }

    }
}