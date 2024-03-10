using Generics.Interfaces;

namespace Generics.Generators
{
    public class BigIntValuesGenerator : IGenerator<int>
    {
        private static readonly Random Random = new Random();
        public int GenerateRandomValues()
        {
            return Random.Next(100_000, 100_000_000);
        }
    }    
}
