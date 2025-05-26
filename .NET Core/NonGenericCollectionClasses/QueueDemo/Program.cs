using System.Collections;

namespace QueueDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            foreach (var item in queue) 
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Topmost element in queue is: {queue.Peek()}");

            int a = (int)queue.Dequeue();

            Console.WriteLine($"Removed element is: {a}");   


        }
    }
}
