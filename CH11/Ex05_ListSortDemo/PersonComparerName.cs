using System.Collections;
namespace Ch11Ex05
{
    public class PersonComparerName : IComparer
    {

        public static IComparer Default = new PersonComparerName();

        int IComparer.Compare(object? x, object? y)
        {
            if (x is Person && y is Person)
            {
                return Comparer.Default.Compare(
                    ((Person)x).Name, ((Person)y).Name);
            }
            else
            {
                throw new ArgumentException(
                    "One or both objects to compare are not Person objects.");
            }
        }
    }
}