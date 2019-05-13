using System;

namespace FooBar
{
    class Runner
    {
        public static int TakeInput()
        {
            string input;
            int convertInput = 0;

            Console.Write("Please type a number: ");
            input = Console.ReadLine();
            convertInput = int.Parse(input);

            return (convertInput);
        }

        public static void DoFooBar(int input)
        {
            for (int i = 0; i < input; i++)
            {
                int r2 = i % 2;
                int r3 = i % 3;

                Console.Write(i + " ");
                if (r2 == 0 && r3 == 0)
                {
                    Console.Write("foobar");
                }
                else if (r2 == 0)
                {
                    Console.Write("foo");
                }
                else if (r3 == 0)
                {
                    Console.Write("bar");
                }
                Console.WriteLine("");
            }
        }
    }
}
