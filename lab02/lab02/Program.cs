namespace lab02/*
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
        Console.WriteLine("Hello, World!");
        string bossName = "Kirin";      //string  เอาไว้เก็บตัวอักษรใน"..."
        char rank = 'S';                // char เอาไว้เก็บตัวอักษรเพียงตัวเดียวใน'.'
        int level = 7;                 // int เอาไว้เก็บตัวเลขจำนวนเต็มบวก,เต็มลบ,0
        int maxHp = 240;
        int currentHp = 175;
        float attackpower = 42.5f;     // เอาใว้เก็บตัวเลขทศนิยม และต้องมี f ต่อท้าย
        Double critmultiplier = 1.75;  // เอาใว้เก็บตัวเลขทสนิยม เก็บได้มากกว่า float
        bool isBoss = true;            // เอาใว้เก็บค่า true หรือ false

        Console.WriteLine("===== Boss Information =====");
        Console.WriteLine($"Name: {bossName}");
        Console.WriteLine($"Rank: {rank}");
        Console.WriteLine($"HP: {currentHp}/{maxHp}");
        Console.WriteLine($"Attack Power: {attackpower}");
        Console.WriteLine($"Critical Multiplier: {critmultiplier}");
        Console.WriteLine($"Is Boss: {isBoss}");
        Console.WriteLine($"Current HP: {currentHp}");
        Console.WriteLine();
        int hpPercent = currentHp * 100 / maxHp;
        Console.WriteLine($"HP Percent: {hpPercent}% ");
        Console.WriteLine();
        Console.WriteLine("Kirin takes 60 damge!");
        Console.WriteLine();
        currentHp = currentHp - 60;
        Console.WriteLine();
        Console.WriteLine("===== Boss STATUS: AFTER DAMAGE =====");
        Console.WriteLine($"HP: {currentHp}/{maxHp}");
        hpPercent = currentHp * 100 / maxHp;
        Console.WriteLine($"HP Percent: {hpPercent}% ");
        //partB

        string Name1 = "a";
        char level1 = '1';
        int maxHp1 = 100;
        int currentHp1 = 50;
        float attackpower1 = 10.5f;
        Double critmultiplier1 = 1.75;
        bool player = true;

        Console.WriteLine("===== Information =====");
        Console.WriteLine($"Name: {Name1}");
        Console.WriteLine($"level: {level1}");
        Console.WriteLine($"HP: {currentHp1}/{maxHp1}");
        Console.WriteLine($"Attack Power: {attackpower1}");
        Console.WriteLine($"Critical Multiplier: {critmultiplier1}");
        Console.WriteLine($"player: {player}");
        Console.WriteLine($"Current HP: {currentHp}");
        Console.WriteLine();
       
        string Name2 = "b";
        char level2 = '1';
        int maxHp2 = 50;
        float attackpower2 = 5.5f;
        Double critmultiplier2 = 2.0;
        bool npc = true;

        Console.WriteLine("===== Information =====");
        Console.WriteLine($"Name: {Name2}");
        Console.WriteLine($"level: {level2}");
        Console.WriteLine($"Attack Power: {attackpower2}");
        Console.WriteLine($"Critical Multiplier: {critmultiplier2}");
        Console.WriteLine($"NPC: {npc}");
        Console.WriteLine($"Current HP: {currentHp}");
        Console.WriteLine();

        string Name3 = "c";
        char level3 = '1';
        int maxHp3 = 75;
        float attackpower3 = 5.5f;
        Double critmultiplier3 = 2.3;
        bool pets = true;

        Console.WriteLine("===== Information =====");
        Console.WriteLine($"Name: {Name3}");
        Console.WriteLine($"level: {level3}");
        Console.WriteLine($"Attack Power: {attackpower3}");
        Console.WriteLine($"Critical Multiplier: {critmultiplier3}");
        Console.WriteLine($"Pets: {pets}");
        Console.WriteLine($"Current HP: {currentHp}");
        Console.WriteLine();

        string Name4 = "d";
        char level4 = '1';
        int maxHp4 = 350;
        float attackpower4 = 40.5f;
        Double critmultiplier4 = 1.23;
        bool monster = true;

        Console.WriteLine("===== Information =====");
        Console.WriteLine($"Name: {Name4}");
        Console.WriteLine($"level: {level4}");
        Console.WriteLine($"Attack Power: {attackpower4}");
        Console.WriteLine($"Critical Multiplier: {critmultiplier4}");
        Console.WriteLine($"Monster: {monster}");
        Console.WriteLine($"Current HP: {currentHp}");
        Console.WriteLine();
    }
}