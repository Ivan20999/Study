using System;
internal class Program
{
    static void Main(string[] args)
    {
        string name, gender, age, placeWork;
        Console.WriteLine("Your name?");
        name = Console.ReadLine();
        Console.WriteLine("Your gender?");
        gender = Console.ReadLine();
        Console.WriteLine("Your age?");
        age = Console.ReadLine();
        Console.WriteLine("Your place of work?");
        placeWork = Console.ReadLine();
        Console.WriteLine("Вас зовут " + name + ", ваш пол " + gender + ", ваш возраст " + age + ", ваше место работы: " + placeWork + ".");
    }
}

