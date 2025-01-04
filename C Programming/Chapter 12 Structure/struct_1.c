#include<stdio.h>
#include<string.h>

int main()
{
//    struct employee
//    {
//        int empId;
//        char name[20];
//        float salary;
//    };
//
//    struct employee e1;
//    struct employee e2 = {1234,"Ram",4000000};

    typedef struct
    {
        int empId;
        char name[20];
        float salary;
    }Emp;

    Emp e1;
    Emp e2 = {1234,"Ram",4000000};

    printf("Enter data for Employee 1\n");
    printf("Emp ID: ");
    scanf("%d",&e1.empId);

    fflush(stdin);
    printf("Emp Name: ");
    gets(e1.name);

    printf("Emp Salary: ");
    scanf("%f",&e1.salary);


    printf("\nEMPLOYEE1 DATA-->\n");
    printf("Emp ID: %d",e1.empId);

    printf("\nEmp Name: ");
    puts(e1.name);

    printf("Emp Salary: %.2f\n",e1.salary);

    printf("\nEMPLOYEE2 DATA-->\n");
    printf("Emp ID: %d",e2.empId);

    printf("\nEmp Name: ");
    puts(e2.name);

    printf("Emp Salary: %.2f\n",e2.salary);

    return 1;
}
