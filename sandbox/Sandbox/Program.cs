using System;



class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello Sandbox World!");

        //Circle myCircle = new Circle();
        //myCircle.SetRadius(10);
        //Console.WriteLine($"{myCircle.GetRadius()}");

        //Console.WriteLine($"{myCircle.GetArea()}");

        //Cylinder cylinder1 = new Cylinder();
        //cylinder1.SetHeight(10);
        //cylinder1.SetCircle(myCircle);
        //Console.WriteLine($"{cylinder1.GetVolume()}");
        //Cylinder myCylinder = new Cylinder(100);
        //Console.WriteLine($"{myCylinder.GetVolume}");

        int duration = 9;

        int sleepTime = 250;
        int count = duration;

        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(10);

        string animationString = "(^_^)(-_-)";

        while (DateTime.Now < endTime)
        {
            Console.Write(animationString[0..5]);
            Thread.Sleep(sleepTime);
            Console.Write("\b\b\b\b\b");
            Console.Write(animationString[5..]);
            Thread.Sleep(sleepTime);
            Console.Write("\b\b\b\b\b");
        }

        while (DateTime.Now < endTime)
            {
                Console.Write(count--);
                Thread.Sleep(1000);
                Console.Write("\b");

            }

        while (DateTime.Now < endTime)
            {
                Console.Write("+");
                Thread.Sleep(sleepTime);
                Console.Write("\b");
                Console.Write("-");
                Thread.Sleep(sleepTime);
                Console.Write("\b");
            }


    }
}