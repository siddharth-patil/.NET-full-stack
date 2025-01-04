#include <stdio.h>
#include <string.h>

// Declaration of the main
// structure
struct Organisation
{
    char organisation_name[20];
    char org_number[20];

    // Declaration of the dependent
    // structure
    struct Employee
    {
        int employee_id;
        char name[20];
        int salary;

    } emp;
};

int main()
{
    struct Organisation org;


    org.emp.employee_id = 10;
    strcpy(org.emp.name , "Mrunal");
    org.emp.salary = 200000;

    strcpy(org.organisation_name , "ABC Pvt ltd");
    strcpy(org.org_number , "GFG13374");


   // Printing the details
    printf("Organisation Name : %s\n",
            org.organisation_name);
    printf("Organisation Number : %s\n",
            org.org_number);
    printf("Employee id : %d\n",
            org.emp.employee_id);
    printf("Employee name : %s\n",
            org.emp.name);
    printf("Employee Salary : %d\n",
            org.emp.salary);
}
