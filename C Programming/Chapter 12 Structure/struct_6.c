// C Program to demonstrate Structure pointer
#include <stdio.h>
#include <string.h>

struct Employee {
	int empId;
	char name[30];
};

int main()
{

	struct Employee s1;
	struct Employee *ptr = &s1;

	  /*int num ;
	  int *ptr = &num;
	  int *ptr; */

	s1.empId = 2135705;
	strcpy(s1.name, "siddharth patil");

	printf("Employee ID: %d\n", ptr->empId); //(*ptr).empId)
	printf("Name: %s\n", (*ptr).name);

	return 0;
}
