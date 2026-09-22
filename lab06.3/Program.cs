////*Student ID: 1690702657
////* Name       :chinasorn saneewong na authaya
// * Section    :129C
// * No.        :N / A
// * Course     : GI113 Computer Programming (GI)
// */

using System;

internal class Program
{
    static void Main(string[] args)
    {
      //*/
      //  int lives = 1;

      //  if (lives <= 0)
      //  {
      //      Console.WriteLine("Game Over!");
      //  }
      //  else
      //  {
      //      Console.WriteLine("Keep Fighting!");
      //  }

      //  Console.WriteLine("Continue Code");


      //  int level2 = 10;

      //  if (level2 <= 5)
      //  {
      //      Console.WriteLine("Boss floor unlocked");
      //  }
      //  else if (level2 >= 5)
      //  {
      //      Console.WriteLine("The door opens.");
      //  }
      //  else
      //  {
      //      Console.WriteLine("The door stays shut");
      //  }


      //  bool isPoisoned = true;

      //  if (isPoisoned == true)
      //  {
      //      Console.WriteLine("You Died");
      //  }
      //  else if (isPoisoned == false)
      //  {
      //      Console.WriteLine("You Lives");
      //  }

      //  //int level = 10;
      //  bool haskey = true;
      //  Console.WriteLine("our level (1-99): ");
      //  bool inputValid = int.TryParse(Console.ReadLine(), out int level);

      //  if (!inputValid || level < 1 || level > 99)
      //  {
      //      Console.WriteLine("Invalid level");
      //  }
      //  else if (level >= 10 && haskey)
      //  {
      //      Console.WriteLine("Boss floor unlocked");
      //  }
      //  else if (level >= 5)
      //  {
      //      Console.WriteLine("The door opens.");
      //  }
      //  else
      //  {
      //      Console.WriteLine("The door stays shut.");
      //  }
       
        int atkgun  =100; 
        int zomdieHp  = 120;
        int ammunition = 20;
         
        Console.WriteLine("==>> Kill zombie <<== ");
        Console.WriteLine("atkgun vs zomdieHp Acctions:"  );
        Console.WriteLine("Acctions1: attack");
        Console.WriteLine("Acctions2: Reload Ammunition");

        Console.WriteLine("choose Acctions(1-2): ");
        bool userInput = int.TryParse(Console.ReadLine(), out int choice);
        if (!userInput || choice < 1 || choice > 2)
        {
            Console.WriteLine("Invalid Acctions");
        }
        else if (choice == 1)
        {
            if (ammunition > 0)
            {
                zomdieHp -= atkgun;
                ammunition--;
                Console.WriteLine($"You attacked the zombie! Zombie HP: {zomdieHp}, Ammunition left: {ammunition}");
            }
            else
            {
                Console.WriteLine("No ammunition left! Reload first.");
            }
        }
        else if (choice == 2)
        {
            ammunition += 10; // Reloading adds 10 ammunition
            Console.WriteLine($"You reloaded! Ammunition now: {ammunition}");
            Console.WriteLine($"You attacked the zombie! Zombie HP: {zomdieHp}, Ammunition left: {ammunition}");
        }

    }
}