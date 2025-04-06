namespace GenericsDemo_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            GenericClassPrinciple ref1 = new GenericClassPrinciple();

            //integer data type
            int x=10, y=20;
            Console.WriteLine($"original val are: {x}  {y}");

            ref1.SwapValues<int>(ref x, ref y);
            Console.WriteLine($"swapped values are: {x}  {y}");

            //string data type
            string str1 = "abc", str2 = "xyz";
            Console.WriteLine($"original val are: {str1}  {str2}");
            ref1.SwapValues<string>(ref str1, ref str2);
            Console.WriteLine($"swapped values are: {str1}  {str2}");

            // Person data type
            Person p1 = new Person { FirstName="abc1", LastName="xyz1"};
            Person p2 = new Person { FirstName = "abc2", LastName = "xyz2" };
            Console.WriteLine($"\nOriginal input values are:{p1} {p2}");
            ref1.SwapValues<Person>(ref p1, ref p2);
            Console.WriteLine($"Swapped input values are:{p1} {p2}");
        }
    }
}
