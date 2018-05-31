using System;

namespace CpuProfilingSample
{
    class Program
    {
        static int FooCount;
        static int BarCount;
        static int BazCount;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter any key to start...");
            Console.ReadKey();

            Console.WriteLine("Started");

            var random = new Random();
            while (true)
            {
                var compare = random.NextDouble();
                if (compare > 0.5)
                {
                    Foo();
                }
                else if (compare > 0.2)
                {
                    Bar();
                }
                else
                {
                    Baz();
                }
            }
        }
        
        private static void Foo()
        {
            BurnCpu();
            FooCount++; // To disable JIT optimizing code (prevent inlining)
        }

        private static void Bar()
        {
            BurnCpu();
            BarCount++; // To disable JIT optimizing code (prevent inlining)
        }

        private static void Baz()
        {
            BurnCpu();
            BazCount++; // To disable JIT optimizing code (prevent inlining)
        }

        private static void BurnCpu()
        {
            var nowTicks = DateTime.Now.Ticks;
            while (DateTime.Now.Ticks < nowTicks + 500)
            {
            }
        }
    }
}