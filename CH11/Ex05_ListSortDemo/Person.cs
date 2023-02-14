
namespace Ch11Ex05
{
    public class Person : IComparable
    {
        public string Name;
        public int Age;
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }
    }
}