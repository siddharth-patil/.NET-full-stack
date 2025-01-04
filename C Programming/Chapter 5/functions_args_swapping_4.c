void swapNumbers(int n1, int n2);

#include<stdio.h>

int main()
{
    int n1,n2;
    printf("Enter value of A and B : ");
    scanf("%d%d",&n1,&n2);

    swapNumbers(n1,n2);

    return 1;
}

void swapNumbers(int num1, int num2)
{
    int temp;

    temp = num1;
    num1 = num2;
    num2 = temp;
    printf("Values after swapping A = %d B = %d",num1,num2);
}
