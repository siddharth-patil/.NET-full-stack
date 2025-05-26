namespace JoinMethodDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main thread started");
            Thread t1 = new Thread(new ThreadStart(DoSomething.Task1));
            Thread t2= new Thread(new ThreadStart(DoSomething.Task2));

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();

            Console.WriteLine("Main thread finished:");
        }
    }
}
