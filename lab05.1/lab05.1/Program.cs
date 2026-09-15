//namespace lab05
/*
 *Student ID: 1690702657
 * Name       :chinasorn saneewong na authaya
 *Section     :129C
 * No.        :N / A
 * Course     : GI113 Computer Programming (GI)
*/


using System;

namespace lab05._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==>> My game dee <<==");
            Console.WriteLine(" HERO health: ");
            bool heroHpOk = int.TryParse(Console.ReadLine(), out int heroHp);
            Console.WriteLine(" HERO Attack: ");
            bool heroAtkOk = int.TryParse(Console.ReadLine(), out int heroAtk);
            Console.WriteLine(" HERO Defense: ");
            bool heroDefOk = int.TryParse(Console.ReadLine(), out int heroDef); 

            Console.WriteLine("==>>monster <<==");
            Console.WriteLine(" MONSTER health: ");
            bool monsterHpOk = int.TryParse(Console.ReadLine(), out int monsterHp);
            Console.WriteLine(" MONSTER Attack: ");
            bool monsterAtkOk = int.TryParse(Console.ReadLine(), out int monsterAtk);
            Console.WriteLine("MONSTER Defense: ");
            bool monsterDefOk = int.TryParse(Console.ReadLine(), out int monsterDef);

            bool isHEROINValid = heroHpOk && heroAtkOk && heroDefOk;
            bool isMONINValid = monsterHpOk && monsterAtkOk && monsterDefOk;
            Console.WriteLine($"HERO STATUS valid: {isHEROINValid}");
            Console.WriteLine($"MONSTER STATUS valid: {isMONINValid}");

            Console.WriteLine($"[HERO] HP: {heroHp} Atk: {heroAtk} Def: {heroDef}");
            Console.WriteLine($"[MONSTER] HP: {monsterHp} Atk: {monsterAtk} Def: {monsterDef}");

            int potionHeal = 8;
            heroHp = heroHp + potionHeal;
            Console.WriteLine($"\nHERO drinks a potion, healing {potionHeal} HP. Hero HP now {heroHp}");

            Console.WriteLine("");
        }
    }

} 
