#include<stdio.h>

int main()
{
    printf("Enter 2 numbers : ");
    int num1,num2,max;
    scanf("%d%d",&num1,&num2);

    max = num1>num2 ? num1:num2;

    printf("%d is greater.",max);

    return 1;
}
