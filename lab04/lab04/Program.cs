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

            Console.WriteLine("+------------------------------+");
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

            Console.WriteLine("How Many potions? ");
            bool isValid = int.TryParse(Console.ReadLine(), out int quantity);
            Console.WriteLine($"valid input : {isValid}");
            Console.WriteLine($"Quantity: {quantity}");

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

        }
    }
}
