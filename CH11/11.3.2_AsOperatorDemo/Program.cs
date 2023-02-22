
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

            //子类可以隐式转换为其基类，
            ClassD obj1 = new();
            ClassA? obj2 = obj1 as ClassA;  //obj2 will be null
            Console.WriteLine($"obj2 is null? {obj2 is null}, type of obj2 is {obj2?.GetType().ToString()}");
            // Console.WriteLine(typeof(ClassD));
            Console.ReadKey();
        }
    }


}