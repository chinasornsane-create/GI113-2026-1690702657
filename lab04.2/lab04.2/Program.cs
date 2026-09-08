using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("+------------------------------+");
            //Console.WriteLine("|      CHARACTER CREATION       |");
            //Console.WriteLine("+------------------------------+");

            //Console.Write("Name your hero: ");
            //Console.Write(">>> ");
            //string playerName = Console.ReadLine();
            //Console.WriteLine($"\nwelcome, {playerName}.your journey begins...");

            //Console.WriteLine("+------------------------+");
            //Console.WriteLine("|   DIFFICULTY SELECT    |");
            //Console.WriteLine("+------------------------+");

            //Console.WriteLine("Choose difficulty (1-3): ");
            //int difficulty = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"DIFFICULTY: {difficulty} SELECTED. good luck out there...");

            Console.WriteLine("+------------------------+");
            Console.WriteLine("|    CHARACTER CREATION   |");
            Console.WriteLine("+------------------------+");
            Console.WriteLine("NAME your character: ");
            string charName = Console.ReadLine();
            Console.WriteLine("Choose your class (1-3): ");
            bool classOk = int.TryParse(Console.ReadLine(), out int ClassNum);
            Console.WriteLine("starting luck (0.0-10.0): ");
            bool luckOk = double.TryParse(Console.ReadLine(), out double luck);
            Console.WriteLine($"\n{charName} the Class-{ClassNum} adventurer enters the dungeon. luck: {luck}");

            Console.WriteLine("+------------------------+");
            Console.WriteLine("|        ITEM SHOP       |");
            Console.WriteLine("+------------------------+");

            Console.WriteLine("How Many potions? ");
            bool isValid = int.TryParse(Console.ReadLine(), out int quantity);
            Console.WriteLine($"valid input : {isValid}");
            Console.WriteLine($"Quantity: {quantity}");

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|          SET VOLUME           |");
            Console.WriteLine("+------------------------------+");
            Console.Write("Set music volume (0.0-1.0): ");
            bool volumeOk = double.TryParse(Console.ReadLine(), out double volume);
            Console.WriteLine($"Valid input: {volumeOk}");
            Console.WriteLine($"Volume: {volume}");
            
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|         NEW SAVE FILE         |");
            Console.WriteLine("+------------------------------+");
            Console.Write("Enter save name: ");
            string saveName = Console.ReadLine();
            Console.Write("Choose save slot (1-3): ");
            bool slotOk = int.TryParse(Console.ReadLine(), out int slot);
            Console.WriteLine($"Save name: {saveName}");
            Console.WriteLine($"Valid input: {slotOk}");
            Console.WriteLine($"Slot: {slot}");
        }
    }
}
