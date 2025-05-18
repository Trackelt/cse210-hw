using System;



class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Sandbox World!");

        Circle myCircle = new Circle();
        myCircle.SetRadius(10);
        Console.WriteLine($"{myCircle.GetRadius()}");
        
        Console.WriteLine($"{myCircle.GetArea()}");

        Cylinder cylinder1 = new Cylinder();
        cylinder1.SetHeight(10);
        cylinder1.SetCircle(myCircle);
        Console.WriteLine($"{cylinder1.GetVolume()}");


    }
}