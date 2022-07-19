using System;

internal class Program
{
    static void Main(string[] args)
    {
        string name = "Oleg", surname = "Odegov";
        Console.WriteLine("Before: " + name + " " + surname);
        (name, surname) = (surname, name);
        Console.WriteLine("After: " + name + " " + surname);
    }
}

