using System;

namespace StacksAndQueueDSProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to stacks and queue data structure problem.");
            Stack stack = new Stack();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Display();
            Console.WriteLine("\n========================================================================");
            stack.Peak();
            stack.Pop();
            stack.IsEmpty();
            stack.Display();
            Console.ReadKey();
        }
    }
}
