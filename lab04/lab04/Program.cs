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
            Console.Write(">>>");
            string playerName = Console.ReadLine();
            Console.WriteLine($"\n\"welcome,{playerName}.your journey begins..");
            Console.Write("Choose a class (1-3): ");
            Console.WriteLine("+------------------------+");
            Console.WriteLine("|   DIFFICULTY SELECT    |");
            Console.WriteLine("+------------------------+");
            Console.WriteLine("Choose difficulty (1-3): ");
            int difficulty =  Convert.ToInt32(Console.ReadLine());
            bool classOk = int.TryParse(Console.ReadLine(), out int classNum);
            Console.Write("Starting luck (0.0-10.0): ");
            bool luckOk = double.TryParse(Console.ReadLine(), out double luck);
            Console.WriteLine($"{playerName} the Class-{classNum} adventurer enters the dungeon. Luck: {luck}");
        }
    }
}
