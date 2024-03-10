using Generics.Interfaces;

namespace Generics.Generators
{
    public sealed class DoubleValuesGenerator : IGenerator<double>
    {
        private static readonly Random Random = new Random();

        public double GenerateRandomValues()
        {
            return Math.Round(Random.NextDouble(), 2);
        }
    }
}