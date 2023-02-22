
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
            //使用AS运算符进行类型转换

            //子类可以隐式转换为其基类，但基类不可隐式转换为子类
            ClassA obj1 = new();
            ClassD? obj2 = obj1 as ClassD;  //obj2 will be null
            if (obj2 is null)
            {
                Console.WriteLine("obj2 is null");
            }
            else
            {
                Console.WriteLine($"obj2 is {obj2.GetType()}");
            }


            ClassD obj3 = new();
            ClassA? obj4 = obj3 as ClassA;  //obj4 will be instance of ClassA(parent)
            if (obj4 is null)
            {
                Console.WriteLine("obj4 is null");
            }
            else
            {
                Console.WriteLine($"obj4 is {obj4.GetType()}");
            }

            Console.ReadKey();

            //使用多态性


        }
    }


}