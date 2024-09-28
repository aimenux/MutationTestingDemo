using System.Diagnostics.CodeAnalysis;
using App;

var x = Random.Shared.Next(1, 10_000);
var y = Random.Shared.Next(1, 10_000);

Console.WriteLine($"x = {x}");
Console.WriteLine($"y = {y}");

var superComputer = new SuperComputer();

var sum = superComputer.Sum(x, y);
var sub = superComputer.Sub(x, y);
var mul = superComputer.Mul(x, y);
var div = superComputer.Div(x, y);

Console.WriteLine($"x + y = {sum}");
Console.WriteLine($"x - y = {sub}");
Console.WriteLine($"x * y = {mul}");
Console.WriteLine($"x / y = {div}");

Console.WriteLine("Press any key to exit program !");
Console.ReadKey();

[ExcludeFromCodeCoverage]
public static partial class Program;