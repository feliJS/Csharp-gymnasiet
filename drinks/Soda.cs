using System.Collections.Generic;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

/// <summary>
/// Klass som tar in namn och pris, s�tter size och representerar olika sodas med egna namn.
/// </summary>


//klass som representerar en l�sk
public class Soda
{
    //namn och pris p� l�sk (som sedan de andra �rver)
    public string Name;
    public int Price;

    //metod f�r att s�tta storlek p� l�sken, d�rmed blir det ocks� priset
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

    /*Metod f�r att att h�mta namnet p� l�sken
     virtual s� den kan overridea s� man enklare kan f� ut fanta choices
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
    //Objekt av Soda, �rver name och price, har egna attributer
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
        //metod f�r att v�lja smak p� fantan
        public void FantaChoice(string flavour)
        {
            this.fantaFlavour = flavour;
        }
        //metod f�r socker typ p� fantan
        public void SugarChoice(string sugar)
        {
            this.sugar = sugar;
        }

        // overrida getName fr�n Soda s� att den returnerar fanta information ocks�
        public override string getName()
        {
            return this.Name + " (" + this.fantaFlavour + ", " + this.sugar + ")";
        }

    }
}