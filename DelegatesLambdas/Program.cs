using System;

namespace DelegatesLambdas
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOp f = Add;
            f = Subtract;

            Console.WriteLine(f(83, 42));

            CalAndPrint(21, 21,  (x, y) => x + y );
            CalAndPrint(21, 21,  (x, y) => x - y ); // Lambda function is a delegate

            CalAndPrint("A", "B", (x, y) => x + y); // Generic Type Constraints
            CalAndPrint(true, true, (x, y) => x && y);
        }
        
        // Type parameter
        delegate T Combine<T>(T a, T b);
        delegate int MathOp(int x, int y);

        static void CalAndPrint<T>(T x, T y, Combine<T> f )
        {
            var result = f(x, y);
            Console.WriteLine(result);
        }

        static int Add(int x, int y)
        {
            return x + y;
        }
        
        static int Subtract(int a, int b)
        {
            return a - b;
        }
    }
}
