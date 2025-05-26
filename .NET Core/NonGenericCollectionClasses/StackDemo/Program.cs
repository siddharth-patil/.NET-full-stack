using System.Collections;

namespace StackDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack(); // Last in First Out or First in Last out
            stack.Push(new Student { Name = "sid", Percentage = 99.78, RollNo=1 });
            stack.Push(new Student { Name = "ram", Percentage = 99.98, RollNo = 2 });
            stack.Push(new Student { Name = "raju", Percentage = 91.78, RollNo = 3 });
            stack.Push(new Student { Name = "davide", Percentage = 81.78, RollNo = 4 });

            //stack.Pop();

            Student RemovedElement = (Student)stack.Pop();
            Console.WriteLine($"Removed element is : {RemovedElement}");

            Student TopElement = (Student)stack.Peek();
            Console.WriteLine($"Top most element is : {TopElement}");

            object[] StudentArr = new object[stack.Count];
            StudentArr = stack.ToArray();

            //OR -> object[] StudentArr = stack.ToArray();

            Console.WriteLine("Stack elements from copied array are: ");
            foreach (object student in StudentArr) 
            {
                Console.WriteLine(student);
            }
        }
    }
}
