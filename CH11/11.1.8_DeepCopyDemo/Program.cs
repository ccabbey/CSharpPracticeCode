using static System.Console;

namespace Ch11DeepCopyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Cloner mySource = new(5);
            Cloner myTarget = (Cloner)mySource.Clone();
            WriteLine($"myTarget.MyContent.Val = {myTarget.MyContent.Val}");
            mySource.MyContent.Val = 2;
            WriteLine($"myTarget.MyContent.Val = {myTarget.MyContent.Val}");
        }
    }
}