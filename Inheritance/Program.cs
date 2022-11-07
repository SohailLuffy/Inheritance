using System;
public class Animal
{
    public void eat() 
    { 
        Console.WriteLine("Eating"); 
    }
}
public class Dog : Animal
{
    public void bark() 
    { 
        Console.WriteLine("Barking"); 
    }
}
public class Puppies : Dog
{
    public void weep() 
    { 
        Console.WriteLine("Weeping"); 
    }
}
class TestInheritance
{
    public static void Main(string[] args)
    {
        Puppies d1 = new Puppies();
        d1.eat();
        d1.bark();
        d1.weep();
    }
}