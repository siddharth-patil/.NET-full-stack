#include <stdio.h>

struct employee {
	char name[30];
	float salary;
};

void printEmployeeInfo(struct employee e);


int main()
{
	struct employee e = {"Ram", 40000 };
	printEmployeeInfo(e);
	printf("\nSalary : %0.2f\n", e.salary);
	return 0;
}

void printEmployeeInfo(struct employee e)
{
	//e.name="abcd";
	e.salary=234234;;
}
