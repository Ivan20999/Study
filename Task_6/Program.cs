using System;

internal class Program
{
    static void Main(string[] args)
    {
        int images = 52;
        int imagesInRow = 3;
        int rowsWithImages = images / imagesInRow;
        int imagesRemained = images % imagesInRow;
        Console.WriteLine("Полностью заполненных рядов с картинками: " + rowsWithImages + ", картинки в остатке: " + imagesRemained + ".");
    }
}

