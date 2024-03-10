using Generics.Interfaces;

namespace Generics.Classes
{
    public abstract class ArrayBase : IArrayBase
    {
        protected virtual void InitArray(bool userFilled = false)
        {
            if (userFilled)
            {
                FillArrayFromUserInput();
            }
            else
            {
                FillArrayWithRandomValues();
            }
        }

        public abstract void RecreateArray(bool userFilled = false);

        public abstract void Print();

        protected abstract void FillArrayFromUserInput();

        protected abstract void FillArrayWithRandomValues();
    }
}