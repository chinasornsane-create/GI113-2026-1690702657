namespace Assignment02/*
 * Student ID :1690702657
 * Name       :chinasorn saneewong na authaya
 * Section    :129C
 * No.        :N/A
 * Course     : GI113 Computer Programming (GI)
 */
{ }
internal class Program
{
    static void Main(string[] args)
    {
        const string MaterialName = "Iron";
        const double SmeltRate = 0.2500;
        const double SalvageRate = 0.3000;
        const double MaxBatch = 500.0;

        Console.WriteLine($"===  Welcome to the Forge  ===");
        Console.WriteLine($"=>Smelt: {SmeltRate} | Salvage: {SalvageRate}");
        Console.WriteLine("--------------------------------------------");

        Console.WriteLine("==== Choose Menu ====");
        Console.WriteLine("=>Key 'S' for Smelt (Ore -> Ingot)");
        Console.WriteLine("=>Key 'B' for Breakdown (Ingot -> Ore)");
        Console.Write("=>(S/B): ");

        string menuInput = Console.ReadLine();

        if (!char.TryParse(menuInput, out char menuChar))
        {
            Console.WriteLine("Error: Invalid menu input or no data was provided");
            return;
        }

        char menu = char.ToUpper(menuChar);


        if (menu == 'S')
        {
            Console.WriteLine($"\n>> You selected menu: Smelt ({MaterialName})");
            Console.Write("Please enter the amount you want to convert: ");
            string amountInput = Console.ReadLine();

            if (double.TryParse(amountInput, out double amount))
            {
                if (amount > 0 && amount <= MaxBatch)
                {
                    double resultIngot = amount * SmeltRate;
                    Console.WriteLine("--- Calculation Results ---");
                    Console.WriteLine($"Smelting {amount} {MaterialName}  Ore");
                    Console.WriteLine($"Result: {resultIngot:F2} Ingot"); 
                }
                else
                {
                    Console.WriteLine($"Error: The amount must be greater than 0 and not exceed the MaxBatch value ({MaxBatch})");
                }
            }
            else
            {
                Console.WriteLine("Error: The amount is invalid (please enter a valid number)");
            }
        }
        else if (menu == 'B')
        {
            Console.WriteLine($"\n>> You selected menu: Breakdown ({MaterialName})");
            Console.Write("=>How much would you like: ");
            string amountInput = Console.ReadLine();

            if (double.TryParse(amountInput, out double amount))
            {
                if (amount > 0 && amount <= MaxBatch)
                {
                    double resultOre = amount / SalvageRate;
                    Console.WriteLine("--- Calculation Results ---");
                    Console.WriteLine($"Breaking  {amount}  Iron Ingot ");
                    Console.WriteLine($"Result: {resultOre:F2} Iron Ore"); 
                }
                else
                {
                    Console.WriteLine($"error: amount");
                }
            }
            else
            {
                Console.WriteLine("error: amount");
            }
        }
        else
        {
            Console.WriteLine("error: menu");
        }
    }
}



