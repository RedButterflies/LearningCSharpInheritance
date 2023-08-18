﻿//Inheritance

class Animal
{
    public string animalType;
    public string name;
    public int age;
    public double weigth;
    public string animalSound;

    public Animal(string animalType, string name, int age, double weigth, string animalSound)
    {
        this.animalType = animalType;
        this.name = name;
        this.age = age;
        this.weigth = weigth;
        this.animalSound = animalSound;
    }

    public void MakeSound()
    {
        Console.WriteLine(animalSound);
    }
    public void Introduction()
    {
        Console.WriteLine("I am a "+animalType + ". My name is "+name+ " I am "+ age +" years old. I weigh "+ weigth + "kilos. I make this sound: "+animalSound );
    }
}

class Tiger : Animal
{
    public int numberOfStripes;

    public Tiger(string animalType, string name, int age, double weigth, string animalSound, int numberOfStripes) : base(animalType, name, age, weigth, animalSound)
    {
        this.numberOfStripes= numberOfStripes;
    }
    public void TigerFunction()
    {
        Console.WriteLine("I have "+ numberOfStripes + "stripes.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal cat = new Animal("cat", "Bambino", 10, 85.5d, "meow");
        Tiger tiger = new Tiger("tiger", "Seran", 8, 905.6d, "Rawr!", 5);

        cat.MakeSound();
        tiger.MakeSound();

    }
}