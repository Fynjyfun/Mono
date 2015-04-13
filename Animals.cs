class Animal
{
    string name;

    public void
}

class Bird : Animal
{
    int wingLength;

    public void Fly()
    {
        Console.WriteLine(name + " is flying");
    }
}

class Cat : Animal
{
    public void Meow()
    {
        Console.WriteLine(name + ": meow");
    }
}

class Lion : Cat
{
    public void Meow()
    {
        Console.WriteLine(name + ": RRRRR!!!");
    }
}

class Program
{
    static void Main()
    {
        
    }
}
