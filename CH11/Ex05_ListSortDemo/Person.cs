
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
            if (obj is Person)
            {
                Person otherPerson = (Person)obj;
                return this.Age - otherPerson.Age;
            }
            else
            {
                throw new ArgumentException("object to compare is not a Person object.");
            }
        }
    }
}