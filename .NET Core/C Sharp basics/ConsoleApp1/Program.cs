//Console.WriteLine("Basics of C#");

//int number = -3342;

//Console.WriteLine("The value for number:{0}", number); // C-style
//Console.WriteLine("The value for number:"+number);  // C++ Style
//Console.WriteLine($"The value for number:{number}"); // C# Style

//int emp_id = 003345;
//string emp_name = "Steve Austin";
//string emp_gender = "Male";
//double emp_salary = 95000.5;

//Console.WriteLine("Employee Details:\n ID:{0}\n Name:{1}\n Gender:{2}\n Salary:{3}",emp_id,emp_name,emp_gender,emp_salary);
//Console.WriteLine("Employee Details:\n ID"+emp_id+"\n Name:"+emp_name+"\n Gender:"+emp_gender+"\n Salary:"+emp_salary);
//Console.WriteLine($"Employee Details:\n Id:{emp_id}\n Name:{emp_name}\n Gender:{emp_gender}\n Salary:{emp_salary}");

//Console.WriteLine("Enter number");
//int number =Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"Number is:{number}");


int[] Arr = new int[5];

Console.WriteLine("Enter Array Values");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"{i + 1} value");
    Arr[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Array elements are:Using For loop\n");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Arr[{i}]={Arr[i]}");
}
Console.WriteLine("Array elements are:Using Foreach loop\n");
foreach (int item in Arr)
{
    Console.WriteLine(item);
}

