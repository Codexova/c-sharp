using System;

class Program
{
    static string[] classNames = { "Tank", "Mage", "Ranger" };

    static int[] classHP = { 140, 80, 100 };

    static int[] classATK = { 14, 30, 22 };

    static int[] classDEF = { 12, 3, 7 };

    static void Main()
    {
        DisplayClasses();

        Console.Write("Choose your class (1-3): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice >= 1 && choice <= 3)
        {
            int index = choice - 1;

            Console.WriteLine("\nYou selected: " + classNames[index]);
            Console.WriteLine("HP: " + classHP[index]);
            Console.WriteLine("Attack: " + classATK[index]);
            Console.WriteLine("Defense: " + classDEF[index]);
        }
        else
        {
            Console.WriteLine("Invalid class selection!");
        }
    }

    static void DisplayClasses()
    {
        Console.WriteLine("===== SELECT YOUR CLASS =====");

        for (int i = 0; i < classNames.Length; i++)
        {
            Console.WriteLine(
                (i + 1) + ". " + classNames[i] +
                " | HP: " + classHP[i] +
                " | ATK: " + classATK[i] +
                " | DEF: " + classDEF[i]
            );
        }
    }
}