
using VeilleTech.UniTests.Calculator;

var calculator = new Calculator();
var average = calculator.Average(10, 20);
Console.WriteLine( average);

Console.ReadLine();

average = calculator.Average(-10, -20);
Console.WriteLine(average);