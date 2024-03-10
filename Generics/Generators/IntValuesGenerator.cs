using Generics.Interfaces;

namespace Generics.Generators
{
    public sealed class IntValuesGenerator : IGenerator<int>
    {
        private static readonly Random Random = new Random();
        
        public int GenerateRandomValues()
        {
            return Random.Next(1, 100);
        }
    }
}
