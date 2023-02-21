
using System;
namespace Ch11AsOperatorDemo
{

    class ClassA : IMyInterface { }

    internal interface IMyInterface
    {
    }

    class ClassD : ClassA { }

    class Program
    {
        static void Main(string[] args)
        {
            ClassA obj1 = new();
            ClassD? obj2 = obj1 as ClassD;
            Console.WriteLine(obj2 is null);
            Console.ReadKey();
        }
    }


}