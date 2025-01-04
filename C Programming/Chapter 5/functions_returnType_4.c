int checkDivisibility(int num);

#include<stdio.h>
#include<stdbool.h>

int main()
{
    int num;
    scanf("%d",&num);

    bool isDivisible = checkDivisibility(num);

    if (isDivisible)
        printf("%d is divisible by 5",num);
    else
        printf("%d is NOT divisible by 5",num);
}

checkDivisibility(int num)
{
    if(num%5==0)
        return 1;
    else
        return 0;
}
