using Generics.Interfaces;

namespace Generics.Classes
{
    public sealed class TwoDimensionalArray<T> : ArrayBase
    {
        private T[,] _array;

        private readonly IGenerator<T> _generator;

        public TwoDimensionalArray(IGenerator<T> generator, bool userFilled = false)
        {
            _generator = generator;
            InitArray();
        }

        protected override void FillArrayFromUserInput()
        {
            for (int i = 0; i < _array.GetLength(0); i++)
            {
                for (int j = 0; j < _array.GetLength(1); j++)
                {
                    Console.WriteLine($"Введите элемент массива с индексом {i} {j}");
                    _array[i, j] = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
                }
            }
        }

        protected override void FillArrayWithRandomValues()
        {
            for (int i = 0; i < _array.GetLength(0); i++)
            {
                for (int j = 0; j < _array.GetLength(1); j++)
                {
                    _array[i, j] = _generator.GenerateRandomValues();
                }
            }
        }

        public override void RecreateArray(bool userFilled = false)
        {
            InitArray();
        }

        protected override void InitArray(bool userFilled = false)
        {
            Console.WriteLine("Введите кол-во строк: ");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите кол-во столбцов: ");
            int columns = int.Parse(Console.ReadLine());
            _array = new T[rows, columns];
            base.InitArray(userFilled);
        }

        public override void Print()
        {
            for (int i = 0; i < _array.GetLength(0); i++)
            {
                for (int j = 0; j < _array.GetLength(1); j++)
                {
                    Console.Write(_array[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}