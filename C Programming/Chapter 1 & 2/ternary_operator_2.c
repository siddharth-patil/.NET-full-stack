#include<stdio.h>

int main()
{
    printf("Enter a number ");
    int num1;

    scanf("%d",&num1);

    num1%2==0 ? printf("Even number"):printf("Odd number");

    return 1;
}
