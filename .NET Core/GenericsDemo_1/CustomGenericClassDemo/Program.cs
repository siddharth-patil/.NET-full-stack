namespace CustomGenericClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericClass<int> int_ref = new GenericClass<int>(5);

            int[] Arr = new int[] {1,2,3,4,5 };

            int_ref.Accept(Arr);

            int[] res = int_ref.Display();

            Console.WriteLine("Array elements are:");

            foreach (int i in res) Console.WriteLine(i);
         }
    }
}
