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

        }
    }