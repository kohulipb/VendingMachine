using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksDispenser
{
    internal class Dispenser
    {
        private Dictionary<Drink, int> inventory = new Dictionary<Drink, int>();

        private float money = 0f;
        public Dispenser() 
        {
            //nothing to do rn
        }

        public void LoadMachine(Drink drinkToLoad, int quantity)
        {
            //If we already have a slot for this product
            if(inventory.ContainsKey(drinkToLoad))
            {
                inventory[drinkToLoad] += quantity;
            }
            //Else create a slot
            else 
            {
                inventory.Add(drinkToLoad, quantity);
            }
           
        }

        public Drink BuyDrink(Drink drinkToBuy)
        {
            if (inventory.ContainsKey(drinkToBuy)) 
            {
                //Is the quantity larger than 0?
                if (inventory[drinkToBuy] > 0)
                {
                    inventory[drinkToBuy] -= 1;
                    Console.WriteLine($"You sucessfully bought a {drinkToBuy.ProductName}");
                    return drinkToBuy;
                }
                //No product left
                else 
                {
                    Console.WriteLine($"Sorry. we are out of {drinkToBuy.ProductName}");
                }

                
            }
            //Product isnt sold here
            else 
            {
                Console.WriteLine($"Sorry, we do not sell {drinkToBuy.ProductName}");
            }
            //return
            return null;
        }

        public override string ToString()
        {
            string productsOnSale = "";
            foreach (Drink item in inventory.Keys) 
            {
                productsOnSale += $"{item.ProductName}: {inventory[item]} pcs\n";
            }
            return productsOnSale;
        }
    }
}
