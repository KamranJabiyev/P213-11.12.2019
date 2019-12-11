using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //DrugType type1 = new DrugType("headache");
            //DrugType type2 = new DrugType("stomachache");
            //Console.WriteLine(type1.Id);
            //Console.WriteLine(type2.Id);
            int x = 5;
            int y = 6;
            string a = "Kamran";
            string b = "Memmed";

            Man man = new Man("Man");
            Woman woman = new Woman("Woman");
            Console.WriteLine();
        }
    }

    abstract class Human
    {
        public string Name;
        public string Surname;
        public bool Gender;

        public Human(string word)
        {
            Console.WriteLine(word);
        }
        public abstract void Eat();

        public virtual void Live()
        {
            Console.WriteLine("Yashamaq gozeldir");
        }

        public void Test()
        {
            Console.WriteLine("Hello");
        }
    }

    class Man : Human
    {
        public Man(string w) : base(w) { }
        public override void Eat()
        {
            Console.WriteLine("Vehshi kimi yeyir");
        }

        public override void Live()
        {
            Console.WriteLine("yashamagi bacarmir");
        }
    }

    class Woman : Human
    {
        public Woman(string w) : base(w)
        {

        }
        public override void Eat()
        {
            Console.WriteLine("Adam kimi yeyir");
        }
    }
}
