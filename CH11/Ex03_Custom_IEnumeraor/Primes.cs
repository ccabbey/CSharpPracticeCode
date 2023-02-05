using System.Collections;
namespace CH11Ex03
{
    class Primes
    {
        private long min;
        private long max;

        public Primes() : this(2, 100) { }

        public Primes(long minimum, long maximum)
        {
            if (minimum < 2)
                min = 2;
            else
                min = minimum;
            max = maximum;
        }
        public IEnumerator GetEnumerator()
        {
            for (long possiblePrimes = min; possiblePrimes <= max; possiblePrimes++)
            {
                bool isPrime = true;
                for (long possibleFactor = 2; possibleFactor <= (long)Math.Floor(Math.Sqrt(possiblePrimes)); possibleFactor++)
                {
                    long remainderAfterDivision = possiblePrimes % possibleFactor;
                    if (remainderAfterDivision == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    yield return possiblePrimes;
                }

            }
        }
    }
}