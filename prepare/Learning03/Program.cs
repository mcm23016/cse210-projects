using System;

class Program
{
    static void Main(string[] args)
    {
        // Initilizing a bunch of objects to test code.
        Fraction imDefault = new Fraction();
        Fraction imOne = new Fraction(1);
        Fraction imFive = new Fraction(5);    
        Fraction imThreeForths = new Fraction(3,4);
        Fraction imOneThird = new Fraction(1,3);

        // Calling Fraction strings and values for each fraction object.
        // Default
        Console.WriteLine(imDefault.toString());
        Console.WriteLine(imDefault.toValue());

        // 1
        Console.WriteLine(imOne.toString());
        Console.WriteLine(imOne.toValue());

        // 5
        Console.WriteLine(imFive.toString());
        Console.WriteLine(imFive.toValue());

        // 3/4
        Console.WriteLine(imThreeForths.toString());
        Console.WriteLine(imThreeForths.toValue());

        // 1/3
        Console.WriteLine(imOneThird.toString());
        Console.WriteLine(imOneThird.toValue());
    }
}