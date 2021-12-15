using System;

namespace TypeSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var myname = "Godfrey";
            myname = myname.ToUpper();
            Console.WriteLine(myname);

            // Boxing
            object o = 42;
            object o2 = 42;
            if (o == o2) 
            {
                Console.WriteLine("Same!");
            }

            if(o.Equals(42))
            {
                Console.WriteLine("Same Here!");
            }

            // Unboxing
            var n = (int)o; // Typecasting

            int myNumber = 42;
            // myNumber = "FooBar";

            dynamic myDynamic = 32;
            myDynamic = "FooBar";

            // Struct or class

            void DoSomething();
            {
                var dt = new DateTime();
                var dt2 = dt;

                var sb = new StringBuilder();
                var sb2 = sb;
            }

            // gabbage collector -> monitors the memory - finalizers
            // GC.Collect(); relevant to reference types
        }
    }
}
