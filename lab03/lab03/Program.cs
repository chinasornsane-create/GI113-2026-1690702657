namespace lab03/*
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
        const int MAXlevel = 100;

        var bossname = "";
        var rank = 's';
        int level = 7;
        int maxhp = 240;
        int currenthp = 115;
        float attack = 42.5f;
        double critmultiplier = 1.75;
        bool isboss = true;

        Console.WriteLine("===== kirin save converter =====");
        Console.WriteLine($"Name: {bossname}" +
             $"\nRank: {rank}" +
             $"\nLevel: {level}" +
             $"\nMax HP: {maxhp}" +
             $"\nCurrent HP: {currenthp}" +
             $"\nAttack: {attack}" +
             $"\nCrit Multiplier: {critmultiplier}" +
             $"\nIs Boss: {isboss}");
        // 1. Implicit coversion int (HP) --->> double 
        Console.WriteLine("\n----- Implicit Conversion: HP as double -----");
        double currenthpDouble = currenthp;
        Console.WriteLine($"Current HP as double: {currenthpDouble}");
        //2 calculate percentage
        Console.WriteLine("\n----- Exact HP Percent (no integer truncation) -----");
        double hpPercentExact = currenthpDouble * 100 / maxhp;
        Console.WriteLine($" HP Percent(exact): {hpPercentExact}%");
        //3.Explicit  float (attackpower) --->> int
        Console.WriteLine("\n----- Explicit Cast: Attack Power -> Display Int -----");
        int attackInt = (int)attack;
        Console.WriteLine($"Attack Power as Integer: {attackInt}");
        //4. Cast vs Convert double (critmultiplier)-->> int
        Console.WriteLine("\n-----Cast vs Convert: Crit Multiplier-----");
        int critMultiplierInt = (int)critmultiplier;
        int critMultiplierConverted = Convert.ToInt32(critmultiplier);
        Console.WriteLine($"Crit Multiplier as Integer: {critMultiplierInt}");
        Console.WriteLine($"Crit Multiplier as Integer (Convert): {critMultiplierConverted}");

    }
}
