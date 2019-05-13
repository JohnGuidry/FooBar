using System;

namespace FooBar
{
    class Program: Runner
    {
        static void Main(string[] args)
        {
            int input = TakeInput();
            DoFooBar(input);
        }
    }
}
