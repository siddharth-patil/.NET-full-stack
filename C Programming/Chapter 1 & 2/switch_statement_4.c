#include<stdio.h>

int main()
{
    /*
    char operation;
    printf("Select from (+, -, *, /) ");
    scanf("%c",&operation);
    */

    int a,b;
    printf("Enter 2 numbers ");
    scanf("%d%d",&a,&b);

    char operation;
    printf("Select from (+, -, *, /) ");
    scanf("%c",&operation);



    switch(operation)
    {
    case '+':
        printf("addition is %d",a+b);
        break;
    case '-':
        printf("subtraction is %d",a-b);
        break;
    case '*':
        printf("ultiplication is %d",a*b);
        break;
    case '/':
        printf("division is %d",a/b);
        break;
    default:
        printf("Incorrect choice");
    }

    return 1;
}
