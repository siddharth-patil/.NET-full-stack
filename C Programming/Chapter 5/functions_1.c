void add(); // Function declaration/prototype
#include<stdio.h>

int main()
{
    printf("FUNCTIONS...!\n");
    add(); // Function call

    return 1;
}

void add() // Function definition
{
    int num1, num2;
    printf("Enter 2 numbers ");
    scanf("%d %d",&num1,&num2);

    printf("Addition = %d",num1+num2);
}
