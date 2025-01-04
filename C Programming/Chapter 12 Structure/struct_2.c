#include<stdio.h>

struct employee
{
    int empId;
    char name[20];
    float salary;
};

int main()
{
    struct employee Emp[2];

    printf("Enter Data of 2 Employees:\n");

    for(int i=0; i<2; i++)
    {
        printf("\nEnter employee Id : ");
        scanf("%d",&Emp[i].empId);

        fflush(stdin);
        printf("\nEnter employee Name : ");
        gets(Emp[i].name);

        printf("\nEnter employee Salary : ");
        scanf("%f",&Emp[i].salary);
    }

    printf("\nEmployee Data - \n");

    for(int i=0; i<2; i++)
    {
        printf("\nEmployee %d Id : %d",i+1,Emp[i].empId);

        printf("\nEmployee %d Name : ",i+1);
        puts(Emp[i].name);

        printf("Employee %d Salary : %f",i+1,Emp[i].salary);
    }

    return 1;
}
