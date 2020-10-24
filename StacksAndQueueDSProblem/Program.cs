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

            Console.WriteLine("\n========================================================================");
            Console.WriteLine("Queue problem");
            Queue queue = new Queue();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.Display();
            Console.WriteLine("\n========================================================================");
            queue.Dequeue();
            queue.IsEmpty();
            Console.ReadKey();

        }
    }
}
