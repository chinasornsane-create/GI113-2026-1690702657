//HEADER - TEMPLATE.txt
namespace Assignment01/*
*Student ID: 1690702657
 * Name       :chinasorn saneewong na authaya
 *Section     :129C
 * No.        :N / A
 * Course     : GI113 Computer Programming (GI)
 */


{
    using System;
        internal class Program
        {
            static void Main(string[] args)
            {
                const string GameTitle = "hero! punch"; 

                var hero = "mako";     
                var Rank = 's';         
                int Level = 100;
                float critChance = 0.75f;
                double staminaPrecise = 90.4;  
                bool isPlayable = true;

                Console.WriteLine(":>:<:>:<:>:<:>:<:>:<:>:<:>:<:>:<:>:<:");
                Console.WriteLine("|       XXXXX      X                |");
                Console.WriteLine("|      XXXXXXX XXXXX                |");
                Console.WriteLine("|     XXXXXXXXXX   XX               |");
                Console.WriteLine("|    X         X                    |");
                Console.WriteLine("|    X         X                    |");
                Console.WriteLine("|    X         X                    |");
                Console.WriteLine("|     X       X                     |");
                Console.WriteLine("|      X     X                      |");
                Console.WriteLine("|       XXXXX                       |");
                Console.WriteLine("|        XXX                        |");
                Console.WriteLine("|        XXX                        |");
                Console.WriteLine("|        XXXXXX                     |");
                Console.WriteLine("|        XXX  XXX                   |");  
                Console.WriteLine("|        XXX     XX                 |");
                Console.WriteLine("|        XXX     XX                 |");
                Console.WriteLine("|        XXX      XXX               |");
                Console.WriteLine("|    XXXXXXXXXXXXXXXXX              |");
                Console.WriteLine("|       XXXX                        |");
                Console.WriteLine("|->->->->->->->->->->->->->->->->-><|");
                Console.WriteLine($"          {GameTitle}              |");
                Console.WriteLine($"|Hero Name   : {hero}                 |");
                Console.WriteLine($"|Rank        : {Rank}                    |");
                Console.WriteLine($"|Level       : {Level}                  |");
                Console.WriteLine($"|Crit Chance : {critChance}                 |");
                Console.WriteLine($"|Stamina     : {staminaPrecise}                 |");
                Console.WriteLine($"|Playable    : {isPlayable}                 |");
                Console.WriteLine($"|                                   |");

                double LevelAsDouble = Level; 
                Console.WriteLine($"|Level as double (implicit): {LevelAsDouble}    |");

                int staminaTruncated = (int)staminaPrecise;              
                int staminaRounded = Convert.ToInt32(staminaPrecise);      
                Console.WriteLine($"|Stamina cast (truncates)  : {staminaTruncated}     |");
                Console.WriteLine($"|Stamina Convert (rounds)  : {staminaRounded}     |");
                Console.WriteLine($"|                                   |");
                Console.WriteLine(":>:<:>:<:>:<:>:<:>:<:>:<:>:<:>:<:>:<:");
            }
        }
}