// ДЗ Класс batman!! добавить
//Andrew Troyals ? учебник + Шилдт полный справочник

using System;

#region Classes
class Animal
{
	public string name;


	// Static - для класса
	// динамическое  - для экземпляра


	static protected int quantity = 0;

	public static int Quantity { get { return quantity;}}


	//Цепочка вызова конструкторов (из одного конструктора можно вызывать другой)
	//(?????!!!!!!!)

	public Animal()
	{
		quantity++;
	}

	//Свойство
	public int cells{ get; set;}

	public virtual void Eat()
	{

		Console.WriteLine("Я, животное, ем!");
	}
}

class Man : Animal
{
	protected bool PhoneSmb = true;

	public override void Eat()
	{

		Console.WriteLine("Я, человек, ем!");
	}

}

class Batman : Man, IFlying
{

	public void Fly()
	{
		Console.WriteLine ("Я, Бетмен, летаю!! Ю-хо!");
	}

	public override void Eat()
	{

		Console.WriteLine("Я, Бетмен, ем!");
	}
}

class Bird : Animal, IFlying
{
    int wingLength;


	public override void Eat()
	{

		Console.WriteLine("Я, птичка, ем!");
	}

    public void Fly()
    {
        Console.WriteLine(name + " is flying");
    }
}

class Cat : Animal
{
	public override void Eat()
	{

		Console.WriteLine("Я, кошка, ем!");
	}

    public void Meow()
    {
        Console.WriteLine(name + ": meow");
    }
}

class Lion : Cat
{

	public override void Eat()
	{

		Console.WriteLine("Я, ЛЕВ(!), ем!");
	}

    public void Meow()
    {
        Console.WriteLine(name + ": RRRRR!!!");
    }
}

class Bat:Animal, IFlying
{
	public void Fly()
	{
		Console.WriteLine ("Я, летучая мышь, лечу!");
	}

}

#endregion

//Интерфейс - список (коллекция) определений методов
//Класс - предок один, а интерфейсов класс может реализовывать много
#region Interfaces
interface IFlying
{
	void Fly();
}

#endregion

class Program
{
    static void Main()
    {
		Animal[] animals = new Animal[4]; 

		Animal animal = new Animal ();
		Bird bird = new Bird ();
		bird.name = "Vasia";
		Cat cat = new Cat();
		Lion lion = new Lion ();

		animals [0] = animal;
		animals [1] = bird;
		animals [2] = cat;
		animals [3] = lion;

		animal.Eat ();
		bird.Eat ();
		cat.Eat ();
		lion.Eat ();

		//animal.cells = 0;

		Console.WriteLine ();

		int i;
		for (i = 0; i < 4; i++) 
		{
			animals[i].Eat();
		}

		Console.WriteLine ();

		((Cat)animals[2]).Eat();

		Console.WriteLine ();

		IFlying[] flying = new IFlying[2];

		Bat bat = new Bat ();

		flying [0] = bat;
		flying [1] = bird;

		for (i = 0; i < 2; i++) 
		{
			flying [i].Fly ();
		}

		Console.WriteLine ();

		Man man = new Man ();
		Batman batman = new Batman ();

		man.Eat ();
		batman.Eat ();
		batman.Fly ();

		Console.WriteLine ();

		Console.WriteLine(Animal.Quantity);

    }
}
