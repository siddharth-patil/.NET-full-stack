#include<stdio.h>

int main()
{
    int num1,num2;

    printf("Enter 2 numbers : ");
    scanf("%d%d",&num1,&num2);

    switch(num1>num2)
    {
    case 0:
        printf("%d is greater",num2);
        break;

    case 1:
        printf("%d is greater",num1);
        break;
    }

    return 1;
}
