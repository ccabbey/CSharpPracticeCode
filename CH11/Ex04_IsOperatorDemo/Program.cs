using static System.Console;

namespace Ch11Ex04
{


    public class Checker
    {
        public void Check(object param1)
        {
            if (param1 is ClassA)
                WriteLine($"Variable can be converted to ClassA");
            else
                WriteLine($"Variable can't be converted to ClassA");
            if (param1 is IMyInterface)
                WriteLine($"Variable can be converted to IMyInterface");
            else
                WriteLine($"Variable can't be converted to IMyInterface");
            if (param1 is MyStruct)
                WriteLine($"Variable can be converted to MyStruct");
            else
                WriteLine($"Variable can't be converted to MyStruct");
        }
    }
    interface IMyInterface { }

    class ClassA : IMyInterface { }

    class ClassB : IMyInterface { }

    class ClassC { }

    class ClassD : ClassA { }

    public struct MyStruct { }

    class Program
    {
        static void Main(string[] args)
        {
            Checker checker = new();
            ClassA try1 = new();
            ClassB try2 = new();
            ClassC try3 = new();
            ClassD try4 = new();
            MyStruct try5 = new();
            object try6 = try5;

            WriteLine("Analyzing ClassA type variable:");
            checker.Check(try1);
            WriteLine("AnAnalyzing ClassB type variable:");
            checker.Check(try2);
            WriteLine("AnAnalyzing ClassC type variable:");
            checker.Check(try3);
            WriteLine("Analyzing ClassD type variable:");
            checker.Check(try4);
            WriteLine("Analyzing MyStruct type variable:");
            checker.Check(try5);
            WriteLine("Analyzing boxed MyStruct type variable:");
            checker.Check(try6);
            ReadKey();

            object[] data = {
                try1,try2,try3,try4,try5,try6};
            foreach (var item in data)
            {
                // if (item is var catcher)
                //     WriteLine("item is " + $"{catcher.GetType().ToString()}");
                WriteLine("item is " + $"{item.GetType().ToString()}");
            }
            ReadKey();
        }
    }


}