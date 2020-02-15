namespace Lib
{
    public interface IComparator
    {
        bool IsSuperior(decimal x, decimal y);
        bool IsInferior(decimal x, decimal y);
        bool IsEquals(decimal x, decimal y);
    }
}