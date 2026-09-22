namespace lab06/*
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
        int lives = 1;

        if (lives <= 0)
        {
            Console.WriteLine("Game Over!");
        }
        else
        {
            Console.WriteLine("Keep Fighting!");
        }

        Console.WriteLine("Continue Code");


        int level2 = 10;

        if (level2 <= 5)
        {
            Console.WriteLine("Boss floor unlocked");
        }
        else if (level2 >= 5)
        {
            Console.WriteLine("The door opens.");
        }
        else
        { 
            Console.WriteLine("The door stays shut");
        }
        
        
        bool isPoisoned = true;

        if (isPoisoned== true)
        {
            Console.WriteLine("You Died");
        }
        else if(isPoisoned == false)
        {
            Console.WriteLine("You Lives");
        }

        //int level = 10;
        bool haskey = true;
        Console.WriteLine("our level (1-99): ");
        bool inputValid = int.TryParse(Console.ReadLine(), out int level);

        if (!inputValid|| level < 1 || level > 99)
        {
            Console.WriteLine("Invalid level");
        }
        else if (level >= 10 && haskey)
        {
                Console.WriteLine("Boss floor unlocked");
        }
        else if (level >= 5 )
        {
                Console.WriteLine("The door opens.");
        }
        else
        {
            Console.WriteLine("The door stays shut.");
        }



    }
}