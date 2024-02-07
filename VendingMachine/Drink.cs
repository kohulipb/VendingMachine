using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksDispenser
{
    internal class Drink
    {
        public enum containerType 
        {
            GlassBottle,
            PlasticBottle,
            Tin
        }
        private string productName;
        public string ProductName
        {
            get 
            {
                return productName;
            }
         
        }
        private float volume; 
        public float Volume { get { return volume; } }
        private string flavour;
        private float price; //HIDDEN AND PRIVATE PRICE

        public string Flavour { get => flavour; set => flavour = value; }
        public float Price //PUBLIC PRICE
        { 
            get => price;  //GET THE HIDDEN VALUE
            set => price = value; //change the hidden value
        }
        private containerType type;
        private bool hasIce;
        public bool HasIce => hasIce;

        public Drink(string productName, string flavour, float price, containerType type, bool hasIce = false, float volume = 0.33f) 
        {
            this.productName = productName;
            this.volume = volume;
            this.flavour = flavour;
            this.price = price;
            this.type = type;
            this.hasIce = hasIce;
        }

        public override string ToString()
        {
            return $"Name: {productName}, Price: {price}, Volume: {volume}, Type of container: {type}, Has ice: {hasIce}, Volume: {volume}";
        }


    }
}
