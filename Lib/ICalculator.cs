namespace Lib
{
    public interface ICalculator
    {
        decimal Sum(decimal x, decimal y);
        decimal Sub(decimal x, decimal y);
        decimal Mul(decimal x, decimal y);
        decimal Div(decimal x, decimal y);
    }
}