#include<stdio.h>

int main()
{
    printf("Enter 3 numbers : ");
    int num1,num2,num3,max;
    scanf("%d%d%d",&num1,&num2,&num3);

    max = num1 > num2 ? num1 : num2;

    max = max > num3 ? max : num3;

    printf("Greater number is %d ",max);

    return 1;
}
