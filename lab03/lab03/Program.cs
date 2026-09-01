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
        int level = 0;
        int maxhp = 0;
        int currenthp = 0;
        float attack = 0;
        double critmultiplier = 0;
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
        //  Implicit coversion int (HP) --->> double 
        Console.WriteLine("\n----- Implicit Conversion: HP as double -----");
        double currenthpAsDouble = currenthp;
        Console.WriteLine($"Current HP as double: {currenthpAsDouble}");
        //2 c
        Console.WriteLine("\n----- Exact HP Percent (no integer truncation) -----");
        double hpPercent = currenthpAsDouble * 100 / maxhp;
        Console.WriteLine($" HP Percent(exact): {hpPercent:F2}%");

    }
}
