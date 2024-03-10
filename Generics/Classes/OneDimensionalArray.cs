using Generics.Interfaces;

namespace Generics.Classes
{
    public sealed class OneDimensionalArray<T> : ArrayBase
    {
        private T[] _array;

        private readonly IGenerator<T> _generator;

        public OneDimensionalArray(IGenerator<T> generator, bool userFilled = false)
        {
            _generator = generator;
            InitArray(userFilled);
        }

        protected override void FillArrayFromUserInput()
        {
            for (int i = 0; i < _array.Length; i++)
            {
                Console.WriteLine($"Введите элемент массива с индексом {i}");
                _array[i] = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            }
        }

        protected override void FillArrayWithRandomValues()
        {
            for (int i = 0; i < _array.Length; i++)
            {
                _array[i] = _generator.GenerateRandomValues();
            }
        }

        public override void RecreateArray(bool userFilled = false)
        {
            InitArray(userFilled);
        }

        protected override void InitArray(bool userFilled = false)
        {
            Console.WriteLine("Введите длину массива: ");
            int capacity = int.Parse(Console.ReadLine());
            _array = new T[capacity];
            base.InitArray(userFilled);
        }

        public override void Print()
        {
            foreach (var item in _array)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }
    }
}