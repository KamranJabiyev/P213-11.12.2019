using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Custom type operators
            //Person p1 = new Person(){ Name="Memmed",Surname="Necefov",Age=29};
            //Person p2 = new Person();
            //p2.Name = "Elman";
            //p2.Surname = "Elibeyov";
            //p2.Age = 18;


            //Test t = new Test { Name="Kamran",Surname="Jabiyev",Age=29};
            //Test t1 = new Test { Name = "ibrahim", Surname = "Nezerov", Age = 29 };

            //Console.WriteLine("x"=="y");
            #endregion

            #region upcasting,downcasting
            //Eagle eagle = new Eagle();
            //int x = 5;
            //upcasting
            //object shark = new Shark();
            //Animal e1 = eagle;
            //object y = x;
            //object a = eagle;

            //downcasting
            //Bird b1 = new Duck();
            //Shark shark = new Shark();
            //object[] animals = { eagle, b1, shark,x};
            //foreach(var animal in animals)
            //{
            //    if (animal is Eagle)
            //    {
            //        Console.WriteLine("Qartaldir");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Her qush qartal deyil");
            //    }
            //}
            //Eagle e1 = (Eagle)b1;


            //downcasting security way-1
            //if((b1 as Eagle) != null)
            //{
            //    Eagle e1 = (Eagle)b1;
            //}
            //else
            //{
            //    Console.WriteLine("Her qush qartal deyil");
            //}

            //downcasting security way-2
            //if (b1 is Eagle)
            //{
            //    Eagle e1 = (Eagle)b1;
            //}
            //else
            //{
            //    Console.WriteLine("Her qush qartal deyil");
            //}
            #endregion

            Dollar usd = new Dollar() { Usd=100};
            Manat azn = (Manat)usd;
            Console.WriteLine(azn.Azn);
        }
    }

    class Manat
    {
        public int Azn { get; set; }
    }

    class Dollar
    {
        public int Usd { get; set; }

        public static explicit operator Manat(Dollar usd)
        {
            return new Manat { Azn = usd.Usd * 2 };
        }

        //public static implicit operator Manat(Dollar usd)
        //{
        //    return new Manat { Azn = usd.Usd * 2 };
        //}
    }

    #region Custom type operators
    //class Person
    //{
    //    public string Name { get; set; }
    //    public string Surname { get; set; }

    //    public int Age { get; set; }

    //    public readonly int x = 5;

    //    public static bool operator >(Person x, Person y)
    //    {
    //        return x.Age > y.Age;
    //    }

    //    public static bool operator <(Person x, Person y)
    //    {
    //        return x.Age < y.Age;
    //    }

    //    //public static bool operator ==(Person x, Person y)
    //    //{
    //    //    return x.Age == y.Age;
    //    //}

    //    //public static bool operator !=(Person x, Person y)
    //    //{
    //    //    return x.Age != y.Age;
    //    //}
    //}

    //class Test : Person { }
    #endregion
    #region polymorphism,upcasting,downcasting
    //abstract class Animal 
    //{
    //    public abstract void Eat();
    //}

    //abstract class Fish : Animal 
    //{
    //    public abstract void Swim();
    //}

    //abstract class Bird : Animal 
    //{
    //    public abstract void Fly();
    //}

    //class Shark : Fish 
    //{
    //    public int Kg { get; set; }
    //    public int SwimingSpeed { get; set; }
    //    public override void Eat()
    //    {
    //        Console.WriteLine("Eat as Fish");
    //    }

    //    public override void Swim()
    //    {
    //        Console.WriteLine("Swim as Fish");
    //    }
    //}

    //class Eagle : Bird 
    //{
    //    public int FlyingSpeed { get; set; }
    //    public override void Eat()
    //    {
    //        Console.WriteLine("Eat as Eagle");
    //    }

    //    public override void Fly()
    //    {
    //        Console.WriteLine("Fly as Eagle");
    //    }
    //}

    //class Duck : Bird 
    //{
    //    public override void Eat()
    //    {
    //        Console.WriteLine("Eat as Duck");
    //    }

    //    public override void Fly()
    //    {
    //        Console.WriteLine("Fly as Duck");
    //    }
    //}
    #endregion
}
