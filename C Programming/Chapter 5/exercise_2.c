int calcPower(int base, int exponent);

#include<stdio.h>

int main()
{
    int base, exponent;
    printf("Enter base and exponent. ");
    scanf("%d%d",&base,&exponent);

    int ans = calcPower(base,exponent);

    printf("Answer is %d.",ans);

    return 1;
}

calcPower(int base, int exponent)
{
    int power=1;
    for(int i=1; i<=exponent; i++)
    {
        power = power * base;
    }

    return power;
}
