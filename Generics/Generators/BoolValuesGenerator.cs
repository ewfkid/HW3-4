using Generics.Interfaces;

namespace Generics.Generators
{
    public sealed class BoolValuesGenerator : IGenerator<bool>
    {
        private static readonly Random Random = new Random();

        public bool GenerateRandomValues()
        {
            return Random.NextDouble() > 0.5;
        }
    }
}