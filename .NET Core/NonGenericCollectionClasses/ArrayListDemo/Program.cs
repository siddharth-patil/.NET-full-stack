using System.Collections;

namespace ArrayListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ////for Singular value type

            ////ArrayList a1 = new ArrayList() { 1,2,3,4,5,6};
            ////Console.WriteLine($"capacity of ArrayList is : {a1.Capacity}");
            ////Console.WriteLine($"size/count of ArrayList is : {a1.Count}");

            //ArrayList a1 = new ArrayList();

            //a1.Add(1);
            //a1.Add(2);
            //a1.Add(3);
            //a1.Add(4);

            //a1.Insert(0, 5);
            //a1.Insert(3, "sid");

            //int[] arr = new int[] { 11, 12, 13 };
            ////a1.AddRange(arr);

            //a1.InsertRange(0,arr);

            //Console.WriteLine("ArrayList elements are :");
            //foreach (var item in a1)  // (int item in a1)
            //{
            //    Console.Write($"\t{item}");
            //}

            ////a1.Sort();

            ////ArrayList subsetArraylist = a1.GetRange(3, 4);

            ////Console.WriteLine("\nArrayList Subset is :");
            ////foreach (var item in subsetArraylist)  // (int item in a1)
            ////{
            ////    Console.Write($"\t{item}");
            ////}

            ////a1.Remove("sid");
            ////a1.RemoveAt(3);
            //a1.RemoveRange(0, 3);

            //Console.WriteLine("\nArrayList elements are :");
            //foreach (var item in a1)  // (int item in a1)
            //{
            //    Console.Write($"\t{item}");
            //}

            ///--------------------------------------------------------///
            

            ArrayList a2 = new ArrayList();

            a2.Add(new Student { RollNo=1, Name="ram", Percentage=98.99});
            a2.Add(new Student { RollNo = 2, Name = "davide", Percentage = 92.99 });
            a2.Add(new Student { RollNo = 3, Name = "steve", Percentage = 90.14});

            //Console.WriteLine("\nArrayList elements are :");
            //foreach (Student student in a2)  // (int item in a1)
            //{
            //    Console.WriteLine($"\t{student}");
            //}

            Console.WriteLine($"Element present at index 1 is: {a2[1]}");
        }
    }
}
