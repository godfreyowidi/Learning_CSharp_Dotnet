using System;
using System.Diagnostics;

var watch = Stopwatch.StartNew();
CountToNearInfinity(); // <<<< Method to benchmark
watch.Stop();
Console.WriteLine(watch.Elapsed);

MeasureTime(() => CountToNearInfinity());

Console.WriteLine($"The result is {MeasureTimeFunc(() => CalculateSomeResult())}");

static void MeasureTime(Action a)
{
    var watch = Stopwatch.StartNew();
    a();
    watch.Stop();
    Console.WriteLine(watch.Elapsed);
}

static int MeasureTimeFunc(Func<int> f)
{
    var watch = Stopwatch.StartNew();
    var result = f();
    watch.Stop();
    Console.WriteLine(watch.Elapsed);
    return result;
}

static void CountToNearInfinity()
{
    for (var i = 0; i < 500000000; i++);
}

static int CalculateSomeResult()
{
    // Simulate some interesting calsulation
    for (var i = 0; i < 500000000; i++);

    // Return a result
    return 42;

}