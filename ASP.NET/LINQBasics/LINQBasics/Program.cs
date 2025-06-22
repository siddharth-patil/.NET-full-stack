namespace LINQBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //int[] Arr = new int[] { 1, 2, 3, 4, 5, 7, 8, 9, 12, 13 };

            //var result = from elem in Arr
            //             where elem >= 5
            //             orderby elem descending
            //             select elem;

            //foreach (var elem in result)
            //{
            //    Console.WriteLine(elem);
            //}

            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1001, Gender= "Male", Name= "Raju", Salary = 123456},
                new Employee { Id = 1002, Gender= "Male", Name= "Golya", Salary = 129459},
                new Employee { Id = 1003, Gender= "Female", Name= "rani", Salary = 102365},
                new Employee { Id = 1004, Gender= "Female", Name= "soni", Salary = 92365}
            };

            //var result = from emp in employees
            //             where emp.Salary > 100000
            //             orderby emp.Id ascending
            //             select emp;

            var result = employees.Where(emp => emp.Salary >= 120000)
                                  .OrderBy(emp => emp.Id);

            foreach (var elem in result)
            {
                Console.WriteLine(elem);
            }
        }
    }
}
