namespace ParameterisedThreadStartDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Math math_ref = new Math();

            Thread t1 = new Thread(new ParameterizedThreadStart(math_ref.printNum));

            t1.Start();
            Console.ReadLine();
        }
    }
}
