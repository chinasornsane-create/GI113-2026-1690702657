//HEADER - TEMPLATE.txt
namespace Assignment01/*
*Student ID: 1690702657
 * Name       :chinasorn saneewong na authaya
 *Section     :129C
 * No.        :N / A
 * Course     : GI113 Computer Programming (GI)
 */


/**
*                                      XXXXXXX      XX                      
* XX     XXXXXXXXXXXX                XXXXXXXXXXX    XX                      
* XX     XXXXXXXXXXXXXXXXXXXXXX    XXXX       XXXX  XX                      
* XX     XX         X         XX  XXX           XXX XX                      
* XX     XX         X          XX XX             XX XX                      
* XX     XX         X          XXXX               XXXX                      
* XXXXXXXXXXXXXXXXX X        XXX XX               XXXX         XXXXX      X 
* XXXXXXXXXXXXXXXXX XXXXXXXXXXX  XX               XXXX        XXXXXXX XXXXX 
* XX     XX         X  XXX        XX              X XX       XXXXXXXXXX   XX
* XX     XX         X    XXX      XX             XX XX      X         X     
* XX     XX         X      XXX     XXX         XXX          X         X     
* XX     XXXXXXXXXX X        XX      XXXXXXXXXXX   XXX      X         X     
* XX     XXXXXXXXXX X         XX       XXXXXXX     XXX       X       X      
*     XXXXX X   X XXXXXX X             XXX      XX            X     X       
*     X   X X   X X      X        XXXXXXXXXXXXXXX              XXXXX        
*     XXXXX X   X X      XXXXX   XXXXX                          XXX         
*     X     X   XXXX     XX  X   XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX         
*     X     XXXXXXXXXXXX X   X   XXXXX                          XXXXXX      
*                                  XXXXX                        XXX  XXX    
*                                       XXXXXXXXXX              XXX     XX  
*                                                               XXX      XXX
*                                                          XXXXXXXXXXXXXXXXX
*                                                              XXXX         
*/
{
    using System;
        internal class Program
        {
            static void Main(string[] args)
            {
                const string GameTitle = "hero! punch"; // const, PascalCase

                var hero = "mako";     // var บน string — ต้องให้ compiler เดาชนิด
                var Rank = 's';         // var บน char
                int Level = 100;
                float critChance = 0.75f;
                double staminaPrecise = 90.5;  // เลขหลังจุดเป็น 5 ขึ้นไป
                bool isPlayable = true;

                Console.WriteLine($"===== {GameTitle} =====");
                Console.WriteLine($"Hero Name   : {hero}");
                Console.WriteLine($"Rank        : {Rank}");
                Console.WriteLine($"Level       : {Level}");
                Console.WriteLine($"Crit Chance : {critChance}");
                Console.WriteLine($"Stamina     : {staminaPrecise}");
                Console.WriteLine($"Playable    : {isPlayable}");
                Console.WriteLine();

                double LevelAsDouble = Level; // implicit — ไม่มี cast
                Console.WriteLine($"Level as double (implicit): {LevelAsDouble}");

                int staminaTruncated = (int)staminaPrecise;               // explicit cast
                int staminaRounded = Convert.ToInt32(staminaPrecise);      // Convert
                Console.WriteLine($"Stamina cast (truncates)  : {staminaTruncated}");
                Console.WriteLine($"Stamina Convert (rounds)  : {staminaRounded}");
            }
        }
}