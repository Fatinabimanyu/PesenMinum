using System;
using System.Collections.Generic;

namespace PesenMinum
{
    public abstract class Drink
    {
        public int price {get; set;}

        public List<DrinkFlavor> drinkFlavor;

        public Drink()
        {
            this.price = 12000;
 
            this.drinkFlavor = new List<DrinkFlavor>();
        }

        public int CalculatePrice()
        {
          int totalPrice = this.price;

          
          foreach(var d in this.drinkFlavor)
          {
              totalPrice += d.price;
          }
            return totalPrice;
        }

        public void AddDrink(DrinkFlavor d)
        {
            this.drinkFlavor.Add(d);
        }


        public string GetDrink()
        {
           string infDrink = string.Empty; 
           foreach(DrinkFlavor df in this.drinkFlavor)
           {
               infDrink += df.Info();
           }
           return infDrink;
        }

       

       public string Info()
       {
           string info = "Drink Order\n";
           info += "Item\t\tPrice\n";
           info += $"{this.ToString()}\t{this.price}\n";

           info += this.GetDrink();


           info += "-------------------------------\n";

           info += $"total\t{this.CalculatePrice()}\n";
           return info;
       }


    }
}
