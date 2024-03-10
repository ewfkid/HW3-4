using Generics.Interfaces;

namespace Generics.Generators
{
    public sealed class StringValuesGenerator : IGenerator<string>
    {
        private static readonly Random Random = new Random();

        private const string Values = "abcdefghijklmnopqrstuvwxyz0123456789";

        public string GenerateRandomValues()
        {
            int length = Random.Next(1, 15);
            string result = "";

            for (int i = 0; i < length; i++)
            {
                int index = Random.Next(Values.Length);
                result += Values[index];
            }

            return result;
        }
    }
}