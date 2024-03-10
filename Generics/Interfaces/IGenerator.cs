namespace Generics.Interfaces
{
    public interface IGenerator <out T>
    {
        T GenerateRandomValues();
    }
}