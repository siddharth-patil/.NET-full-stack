#include <stdio.h>

int main()
{

    typedef struct employee
    {
        int id;
        char name[20];
        float sal;
    }e;

    e emp1;
    e emp2 = {3,"Pradnya",70000};

    printf("\n Enter Data for emp1\n ");

    printf("\n Enter Employee Id");
    scanf("%d",&emp1.id);

    fflush(stdin);

    printf("\n Enter Employee Name");
    gets(emp1.name);

    printf("\n Enter Employee Salary");
    scanf("%f",&emp1.sal);

    printf("\n Data of Emp1\n");

    printf("\n Id - %d\n Name - ",emp1.id);
    puts(emp1.name);
    printf(" Salary - %.2f\n",emp1.sal);

    printf("\n Data of Emp2\n");

    printf("\n Id - %d\n Name - ",emp2.id);
    puts(emp2.name);
    printf(" Salary - %.2f\n",emp2.sal);

    return 0;
}
