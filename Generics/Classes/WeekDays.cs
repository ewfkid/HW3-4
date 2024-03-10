using Generics.Interfaces;

namespace Generics.Classes
{
    public class WeekDays : IPrinter
    {
        private readonly string[] _days = { "Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday" };

        public void Print()
        {
            foreach (string day in _days)
            {
                Console.Write(day + " ");
            }
        }
    }    
}
