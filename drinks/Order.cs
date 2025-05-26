using System.Collections.Generic;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Diagnostics;


/// <summary>
/// Order klass som kan l�gga till valda sodas i en lista, calculate price och ta ut kvittot
/// </summary>


//Klass som representerar best�llning
public class Order
{
    //lista med sodas som ing�r i best�llningen
    public List<Soda> Sodas = new List<Soda>();

    //metod f�r att l�gga till en soda i en best�llning
    public void addSoda(Soda soda) { 
        Sodas.Add(soda);
    
    }

    //metod f�r att r�kna ut det totala priset f�r best�llningen 
    public int calculatePrice()
    {
        int price = 0;
        //loopar igenom alla l�sk i best�llningen och l�gger ihop priset 
        foreach (Soda i in Sodas)
        {
            price += i.Price;
        }
        return price;
    }

    //metod f�r att skapa ett kvitto f�r best�llningen
    public String getReceipt()
    {
        string wholeReceipt = "";
        
        //loopar igenom alla l�sk i best�llningen och l�gger till namn och pris till kvittot
        foreach (Soda i in Sodas)
        { 
            wholeReceipt += ("\n" + i.getName() + " - " + i.Price).ToString();
            
        }
        //l�gger till totalpriset l�ngst ner p� kvittot *OBS �NDRA!*
        wholeReceipt +=  "\n" + "\n" +  "Total: " + calculatePrice();
        return wholeReceipt;
    }

}