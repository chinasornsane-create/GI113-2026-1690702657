using System.Diagnostics.CodeAnalysis;

namespace lab04/*
 * Student ID :1690702657
 * Name       :chinasorn saneewong na authaya
 *Section     :129C
 * No.        :N/A
 * Course     : GI113 Computer Programming (GI)
 */
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("+------------------------------+"); //แค่
            Console.WriteLine("|      CHARACTER CREATION       |");
            Console.WriteLine("+------------------------------+");

            Console.Write("Name your hero: ");
            Console.Write(">>> ");
            string playerName = Console.ReadLine();
            Console.WriteLine($"\nwelcome, {playerName}.your journey begins...");

            Console.WriteLine("+------------------------+");
            Console.WriteLine("|   DIFFICULTY SELECT    |");
            Console.WriteLine("+------------------------+");

            Console.WriteLine("Choose difficulty (1-3): ");
            int difficulty =  Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"DIFFICULTY: {difficulty} SELECTED. good luck out there...");

            Console.WriteLine("+------------------------+");
            Console.WriteLine("|        ITEM SHOP       |");
            Console.WriteLine("+------------------------+");

            Console.WriteLine("HOW Many potions ? ");
            bool isValid = int.TryParse(Console.ReadLine(), out int quantity);
            Console.WriteLine($"valid input : {isValid}");
            Console.WriteLine($"Quantity: {quantity}");

        }
    }
}
