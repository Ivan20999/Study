using System;

namespace Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How much gold do you have?");
            int coins = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("How many crystals do you wish to purchase?");
            int numberCrystals = Convert.ToInt16(Console.ReadLine());
            int crystalPrice = 2;

            if ((coins / crystalPrice) >= numberCrystals)
            {
                coins -= crystalPrice * numberCrystals;
                Console.WriteLine("Congratulations! You have purchased: " + numberCrystals + " crystals. " + "There is gold left: " + coins + ".");
            }
            else
            {
                Console.WriteLine("Operation failed! We need more gold!");
            }
        }
    }
}
