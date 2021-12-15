using System;

Func<int, int> calculator = CreateCalculator();
Console.WriteLine(calculator(2));

int CalculateSomething(int n) 
{
    if (n == 0) return 0;

    var factor = 42;
    return factor * CalculateSomething(n - 1);
}

Func<int, int> CreateCalculator() // Factory pattern
{
    var factor = 42;
    return n => n * factor;
}

Bestfriends CreateCalulatorInternal()
{
    return new Bestfriends { factor = 42 };
}
class Bestfriends
{
    public int factor;
    public int Calculator(int n) => n * factor;
}