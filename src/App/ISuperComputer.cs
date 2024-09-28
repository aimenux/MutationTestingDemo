namespace App;

public interface ISuperComputer : ICalculator, IComparator;

public interface ICalculator
{
    decimal Sum(decimal x, decimal y);
    decimal Sub(decimal x, decimal y);
    decimal Mul(decimal x, decimal y);
    decimal Div(decimal x, decimal y);
}

public interface IComparator
{
    bool IsSuperior(decimal x, decimal y);
    bool IsInferior(decimal x, decimal y);
    bool IsEquals(decimal x, decimal y);
}