using System.Collections.Generic;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Diagnostics;


/// <summary>
/// Order klass som kan lägga till valda sodas i en lista, calculate price och ta ut kvittot
/// </summary>


//Klass som representerar beställning
public class Order
{
    //lista med sodas som ingår i beställningen
    public List<Soda> Sodas = new List<Soda>();

    //metod för att lägga till en soda i en beställning
    public void addSoda(Soda soda) { 
        Sodas.Add(soda);
    
    }

    //metod för att räkna ut det totala priset för beställningen 
    public int calculatePrice()
    {
        int price = 0;
        //loopar igenom alla läsk i beställningen och lägger ihop priset 
        foreach (Soda i in Sodas)
        {
            price += i.Price;
        }
        return price;
    }

    //metod för att skapa ett kvitto för beställningen
    public String getReceipt()
    {
        string wholeReceipt = "";
        
        //loopar igenom alla läsk i beställningen och lägger till namn och pris till kvittot
        foreach (Soda i in Sodas)
        { 
            wholeReceipt += ("\n" + i.getName() + " - " + i.Price).ToString();
            
        }
        //lägger till totalpriset längst ner på kvittot *OBS ÄNDRA!*
        wholeReceipt +=  "\n" + "\n" +  "Total: " + calculatePrice();
        return wholeReceipt;
    }

}