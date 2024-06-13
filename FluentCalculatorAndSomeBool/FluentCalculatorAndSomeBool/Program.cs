using FluentCalculatorAndSomeBool;

var someBool = new SomeBool();
Console.WriteLine(someBool == true && someBool == false);
Console.WriteLine();
// same
// Console.WriteLine(someBool.Equals(true) && someBool.Equals(false));

var FluentCalculator = new FluentCalculator();
_ = FluentCalculator.one.plus;

// undefined statement
// FluentCalculator.one.one;

Console.WriteLine("Should be: 3");
Console.WriteLine($"Is: {FluentCalculator.one.plus.two}\n");

// undefined statement
// FluentCalculator.one.plus.plus

Console.WriteLine("Should be: -1");
Console.WriteLine($"Is: {FluentCalculator.one.plus.two.plus.three.minus.one.minus.two.minus.four}\n");

Console.WriteLine("Should be: 1");
Console.WriteLine($"Is: {FluentCalculator.one.plus.ten - 10}");