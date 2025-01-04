#include<stdio.h>

int main()
{
    int num, rem, sum=0;
    scanf("%d",&num);

    // int temp = num;

    while(num>0)
    {
        rem = num%10;
        sum += rem;
        num /=10;
    }
    printf("sum is %d",sum);
    return 1;
}
