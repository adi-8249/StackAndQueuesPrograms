using System;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack and Queues programs");
            //Stack Operations 
            Stack stack = new Stack();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Display();
            stack.IsEmpty();
            //Queue operations

            Queue queue = new Queue();
            queue.QueueCreation(50);
            queue.QueueCreation(30);
            queue.QueueCreation(70);
            queue.Display();
            queue.Dequeue();
            queue.Display();

        }
    }
}
