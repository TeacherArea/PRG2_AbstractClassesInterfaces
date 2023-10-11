using System;

// Hur ser det ut med interface? Se textfilen MedInterface ...
abstract class Animal
{
    private string name; // prova att skriva denna som readonly. Se även hur det påverkar classdiagrammet
    public string Name { get; set; }

    public abstract string Speak();

    public void Eat(string food)
    {
        Console.WriteLine($"{Name} äter {food}");
    }
}

class Dog : Animal
{
    public Dog(string name) // : base (name) vid readonly av private i Animal
    {
        this.Name = name;
    }

    public override string Speak()
    {
        return $"{Name} säger Woof!";
    }
}

class Cat : Animal
{
    public Cat(string name)
    {
        this.Name = name; // ta bort denna rad och se vad som händer.
    }

    public override string Speak()
    {
        return $"{Name} säger Meow!";
    }
}

class Program
{
    static void Main()
    {
        Dog dog = new Dog("Hunden Pelle");
        Cat cat = new Cat("Katten Stina");

        dog.Eat("hundmat");
        cat.Eat("kattmat");

        Console.WriteLine(dog.Speak());
        Console.WriteLine(cat.Speak());
    }
}
