//Console.WriteLine("Basics of C#");

// Display Number on Console
//int number = -3342;

//Console.WriteLine("The value for number:{0}", number); // C-style
//Console.WriteLine("The value for number:"+number);  // C++ Style
//Console.WriteLine($"The value for number:{number}"); // C# Style

//Display Multiple values in console

//int emp_id = 003345;
//string emp_name = "Steve Austin";
//string emp_gender = "Male";
//double emp_salary = 95000.5;

//Console.WriteLine("Employee Details:\n ID:{0}\n Name:{1}\n Gender:{2}\n Salary:{3}",emp_id,emp_name,emp_gender,emp_salary);
//Console.WriteLine("Employee Details:\n ID"+emp_id+"\n Name:"+emp_name+"\n Gender:"+emp_gender+"\n Salary:"+emp_salary);
//Console.WriteLine($"Employee Details:\n Id:{emp_id}\n Name:{emp_name}\n Gender:{emp_gender}\n Salary:{emp_salary}");



// Accept number from console
//Console.WriteLine("Enter number");
//int number =Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"Number is:{number}");

//Array

//int[] Arr = new int[5];

//Console.WriteLine("Enter Array Values");
//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine($"{i+1} value");
//    Arr[i] =Convert.ToInt32(Console.ReadLine());
//}

//Console.WriteLine("Array elements are:Using For loop\n");
//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine($"Arr[{i}]={Arr[i]}");
//}
//Console.WriteLine("Array elements are:Using Foreach loop\n");
//foreach (int item in Arr)
//{
//    Console.WriteLine(item);
//}



//Writing Methods in C#

//void Add()
//{
//    int no1, no2;
//    Console.WriteLine("Enter numbers");
//    no1 =Convert.ToInt32(Console.ReadLine());
//    no2 = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine($"Addition of {no1} and {no2} is:{no1+no2}");
//}

//Add();


//Pass by Value mechanism
//int Add(int n1,int n2)
//{
//    return (n1 + n2);
//}
//int Sub(int n1, int n2)
//{
//    return (n1 - n2);
//}
//int Mul(int n1, int n2)
//{
//    return (n1 * n2);
//}
//double Div(int n1, int n2)
//{
//    return ((double)n1 / n2);
//}

//Console.WriteLine("Enter numbers");
//int no1 = Convert.ToInt32(Console.ReadLine());
//int no2 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"\n Following are the results of operations for inputs {no1} and {no2} \n Addition:{Add(no1,no2)}  \n Substraction:{Sub(no1, no2)}   \n Multiplication:{Mul(no1, no2)}   \n Division:{Div(no1, no2)}");
//Console.Read();


//Pass by Address

//Need
//void Swap(int x,int y)
//{
//    int temp = x;
//    x = y;
//    y = temp;

//    Console.WriteLine($"\n Formal parameter values:x:{x} y:{y}");
//}

//int no1 = -10, no2 = -20;
//Console.WriteLine($"\n Original input values are : no1:{no1} no2:{no2}");
//Swap(no1, no2);
//Console.WriteLine($"\n Input values after calling Swap : no1:{no1} no2:{no2}");


// Pass By Address for Input Variables (ref).

void Swap(ref int x, ref int y)
{
    int temp = x;
    x = y;
    y = temp;

    //Console.WriteLine(x);

}

int no1 = -10, no2 = -20;
Console.WriteLine($"\n Original input values are : no1:{no1} no2:{no2}");
Swap(ref no1, ref no2);
Console.WriteLine($"\n Input values after calling Swap : no1:{no1} no2:{no2}");

// Pass by Address for Output Variables (out).

void DoCalculate(int l, int b, out int A, out int P)
{
    A = l * b;
    P = 2 * (l + b);
}


int len = 10, bre = 20;
int Area, Perimeter;

DoCalculate(len, bre, out Area, out Perimeter);
Console.WriteLine($"Area for Rectangle is:{Area} \nPerimeter for Rectangle is:{Perimeter}");


//string[] Arr = new string[5];
//double[] Arr = new double[5];
object[] Arr = new object[5];
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Arr[{i}]:{Arr[i]}");
}

