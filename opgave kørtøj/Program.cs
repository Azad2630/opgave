using opgave_kørtøj.animal;
using opgave_kørtøj.Personer;
using opgave_kørtøj.kørtøjer;
using System;

class Program
{
    static void Main(string[] args)
    {
        Person elev = new Elev("Elev Navn");
        Console.WriteLine(elev.SayHello("elev"));
        Console.WriteLine(elev.SayHello("elev", elev.name));
        elev.ShowMyIdentity();

        Console.WriteLine();

        Person laerer = new Laerer("Lærer Navn");
        Console.WriteLine(laerer.SayHello("lærer"));
        Console.WriteLine(laerer.SayHello("lærer", laerer.name));
        laerer.ShowMyIdentity();

        Console.WriteLine();

        
        Animal cat = new Cat();
        Animal dog = new Dog();

        cat.MakeSound();
        dog.MakeSound();
    }
}
