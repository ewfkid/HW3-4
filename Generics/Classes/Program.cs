using Generics.Generators;
using Generics.Interfaces;

namespace Generics.Classes
{
    public static class Program
    {
        private static BoolValuesGenerator _boolValuesGenerator = new BoolValuesGenerator();

        private static IntValuesGenerator _intValuesGenerator = new IntValuesGenerator();

        private static DoubleValuesGenerator _doubleValuesGenerator = new DoubleValuesGenerator();

        private static StringValuesGenerator _stringValuesGenerator = new StringValuesGenerator();

        public static void Main(string[] args)
        {
            IPrinter[] data = new IPrinter[5];

            data[0] = new OneDimensionalArray<bool>(_boolValuesGenerator);
            data[1] = new OneDimensionalArray<string>(_stringValuesGenerator, true);
            data[2] = new TwoDimensionalArray<double>(_doubleValuesGenerator);
            data[3] = new TwoDimensionalArray<int>(_intValuesGenerator, true);
            data[4] = new WeekDays();

            for (int i = 0; i < data.Length; i++)
            {
                data[i].Print();
            }
        }
    }
}