void swapNumbers(int *,int *);

#include<stdio.h>

int main()
{
    int num1,num2;

    printf("Enter num1 and num2 values : ");
    scanf("%d%d",&num1,&num2);

    swapNumbers(&num1, &num2);

    printf("Values after swapping - num1 = %d, num2 = %d",num1,num2);

    return 1;
}

swapNumbers(int *n1, int *n2)
{
    int temp = *n1;
     *n1 = *n2;
     *n2 = temp;
}
