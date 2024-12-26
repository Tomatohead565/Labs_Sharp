﻿using System;
using System.Xml;
using System.Xml.Linq;

namespace ClassLibrary1
{

[Commentatrobiuterter("Abstractnoye zhivotnoe - ego net")]
public abstract class Animal
{
    public string Country { get; set; }
    public bool HideFromOtherAnimals { get; set; }
    public string Name { get; set; }
    public eClassificationAnimal WhatAnimal { get; set; }

    public Animal(string Country, bool aaaa, string name)
    {
        this.Country = Country;
        this.HideFromOtherAnimals = aaaa;
        this.Name = name;
    }

    public abstract void SayHello();

    public eFavouriteFood GetFavouriteFood()
    {
        if(WhatAnimal == eClassificationAnimal.Herbivores)
        {
            return eFavouriteFood.Plants;
        }
        else if (WhatAnimal == eClassificationAnimal.Carnivores)
        {
            return eFavouriteFood.Meat;
        }
        else
        {
            return eFavouriteFood.Everything;
        }
    }


    public void Deconstruct() 
    { 
    }



    public abstract eClassificationAnimal GetClassificationAnimal();




}


public enum eClassificationAnimal
{
    Herbivores,
    Carnivores,
    Omnivores
}

public enum eFavouriteFood
{
    Meat,
    Plants,
    Everything
}

[Commentatrobiuterter("Spotted cow")]
public class Cow : Animal
{
    public Cow(string country, bool aaaa, string name):base(country, aaaa,name)
    {
        
    }

    public override void SayHello()
    {
        Console.WriteLine("Mooooooo");
    }

    public override eClassificationAnimal GetClassificationAnimal()
    {
        return WhatAnimal;
    }




}

[Commentatrobiuterter("Cool lion")]
public class Lion : Animal
{
    public Lion(string country, bool aaaa, string name) : base(country, aaaa, name)
    {

    }

    public override void SayHello()
    {
        Console.WriteLine("Roar");
    }

    public override eClassificationAnimal GetClassificationAnimal()
    {
        return WhatAnimal;
    }

}

[Commentatrobiuterter("Pink pig")]
public class Pig : Animal
{
    public Pig(string country, bool aaaa, string name) : base(country, aaaa, name)
    {

    }

    public override void SayHello()
    {
        Console.WriteLine("Oink oink");
    }

    public override eClassificationAnimal GetClassificationAnimal()
    {
        return WhatAnimal;
    }

}

[AttributeUsage(AttributeTargets.Class)]
public class Commentatrobiuterter : Attribute
{
    public string comment { get; }

    public Commentatrobiuterter(string comment)
    {
        this.comment = comment;
    }
}

}