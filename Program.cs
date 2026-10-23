using System;

class Program
{
    //PLAYER CLASS DATA
    // Each array uses the same index: index 0 = Tank, 1 = Mage, 2 = Ranger
    static string[] classNames = { "Tank", "Mage", "Ranger" };
    static int[] classHP = { 135, 80, 100 };  
    static int[] classATK = { 12, 30, 22 };   
    static int[] classDEF = { 12, 3, 6 };     

    // EnEMY DATA 
    static string[] enemyNames = new string[5];
    static int[] enemyHP = new int[5];
    static int[] enemyATK = new int[5];
    static int[] enemyDEF = new int[5];

    //Stores which class the player picked 
    static int playerClass = 0;

    // Program starts here
    static void Main()
    {
        Enemies();\
        int choice = 0; // Stores the menu choice

        // Keep showing the menu until it choses 3 (Exit)
        while (choice != 3)
        {
            Console.Clear();    // Clear the screen 
            Console.WriteLine("===== MAIN MENU =====");

            Console.WriteLine("1. Play campaign  (Stages 1 to 5)");
            Console.WriteLine("2. Credits        (Shows the credits)");
            Console.WriteLine("3. Exit           (Quit program)");
            choice = ReadChoice(1, 3);  // Get a valid choice from 1 to 3
            Console.WriteLine();

            //Campaign
            if (choice == 1)
            {
                DisplayClasses();   // Show the list of classes with their stats
                Console.WriteLine();
                Console.WriteLine("Choose your class (1-3):");
                playerClass = ReadChoice(1, 3) - 1;  // Subtract 1 to turn 1-3 into index 0-2

                Console.WriteLine();
                Console.WriteLine("You chose " + classNames[playerClass] + "!");
                Console.WriteLine();
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();     // Wait for the player to press Enter
            }

            //Credits
            if (choice == 2)
            {
                Console.WriteLine("===== CREDITS =====");
                Console.WriteLine("Uncle Migs");
                Console.WriteLine("Briks De Vera");
                Console.WriteLine("Palanas Bien");
                Console.WriteLine();
                Console.WriteLine("Press Enter to go back to the menu...");
                Console.ReadLine();  // Wait so the credits stay on screen
            }
        }
    }

    // asks the player for a number between min and max
    // keeps asking until the input is valid, then returns it
    static int ReadChoice(int min, int max)
    {
        int choice = 0; // Holds the converted number
        bool valid = false; // checks whether the input was acceptable

        do
        {
            string input = Console.ReadLine();  // Read what was typed
            valid = int.TryParse(input, out choice); // Tries to convert it to a number

            // Reject input that isn't a number or is outside the allowed range
            if (!valid || choice < min || choice > max)
            {
                valid = false;
                Console.WriteLine("Invalid input. Try again.");
            }
        }
        while (!valid); // Repeat until the input is valid

        return choice; // Send the valid number back
    }

    // Fills the enemy arrays 
    static void Enemies()
    {
        // Stage 1
        enemyNames[0] = classNames[0];
        enemyHP[0] = classHP[0];
        enemyATK[0] = classATK[0];
        enemyDEF[0] = classDEF[0];

        // Stage 2
        enemyNames[1] = classNames[1];
        enemyHP[1] = classHP[1];
        enemyATK[1] = classATK[1];
        enemyDEF[1] = classDEF[1];

        // Stage 3
        enemyNames[2] = classNames[2];
        enemyHP[2] = classHP[2];
        enemyATK[2] = classATK[2];
        enemyDEF[2] = classDEF[2];

        // Stage 4
        enemyNames[3] = "Mini Boss";
        enemyHP[3] = 170;
        enemyATK[3] = 27;
        enemyDEF[3] = 5;

        // Stage 5
        enemyNames[4] = "Boss";
        enemyHP[4] = 230;
        enemyATK[4] = 32;
        enemyDEF[4] = 8;
    }

    // Prints every class with its stats
    static void DisplayClasses()
    {
        Console.WriteLine("===== SELECT YOUR CLASS =====");

        // Loop through each class by index
        for (int i = 0; i < classNames.Length; i++)
        {
            // Show it as "1. Tank | HP: 135 | ATK: 12 | DEF: 12"
            // (i + 1) makes the list start at 1 instead of 0
            Console.WriteLine(
                (i + 1) + ". " + classNames[i] +
                " | HP: " + classHP[i] +
                " | ATK: " + classATK[i] +
                " | DEF: " + classDEF[i]
            );
        }
    }
}
