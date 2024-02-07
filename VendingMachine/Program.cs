using System.Security.Cryptography.X509Certificates;

namespace DrinksDispenser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create drinks types
            Drink cola = new Drink("Coca-Cola", "Cola", 2.75f, Drink.containerType.Tin);
            Drink sprite = new Drink("Sprite", "Lime", 2.75f, Drink.containerType.PlasticBottle);
            Drink monster = new Drink("Monster Energy", "Battery Acid", 3.00f, Drink.containerType.Tin, false, 0.50f);
            Drink bigWater = new Drink("Fuji Walter", "Wet", 30.00f, Drink.containerType.PlasticBottle, volume: 0.5f);

            //Create dispensers
            Dispenser dispenser = new Dispenser();

            //Load the machine with drinks
            dispenser.LoadMachine(cola, 5);
            dispenser.LoadMachine(sprite, 5);
            dispenser.LoadMachine(monster, 5);
            dispenser.LoadMachine(bigWater, 5);


            Console.WriteLine(dispenser);


        }
    }
}