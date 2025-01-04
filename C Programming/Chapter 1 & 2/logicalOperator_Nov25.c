#include<stdio.h>

int main()
{
    int num1,num2,num3,max;

    printf("Give 3 numbers for comparison ");
    scanf("%d%d%d",&num1,&num2,&num3);

    if ((num1>num2) && (num1>num3))
        max = num1;
    else if (num2>num3)
        max = num2;
    else
        max = num3;

    printf("Greater number among %d %d and %d is %d.",num1,num2,num3,max);

    return 0;
}
