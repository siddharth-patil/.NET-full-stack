namespace SingletonDesignPatternDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            Console.WriteLine("Singleton Demo");

            Singleton ref1 = Singleton.getInstance;
            ref1.Get("1st reference calling..");

            Singleton ref2 = Singleton.getInstance;
            ref2.Get("1st reference calling..");
        }
    }
}
