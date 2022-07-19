using System;
internal class Program
{
    static void Main(string[] args)
    {
        string name;
        string gender;
        string age;
        string placeWork;

        Console.WriteLine("Your name?");
        name = Console.ReadLine();
        Console.WriteLine("Your gender?");
        gender = Console.ReadLine();
        Console.WriteLine("Your age?");
        age = Console.ReadLine();
        Console.WriteLine("Your place of work?");
        placeWork = Console.ReadLine();
        Console.WriteLine("Your name " + name + ", your gender " + gender + ", your age " + age + ", your place of work: " + placeWork + ".");
    }
}

