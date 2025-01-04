#include<stdio.h>

int main()
{
    printf("Enter numerator and denominator ");

    int numerator, denominator, quotient, remainder;

    scanf("%d%d",&numerator,&denominator);

    quotient = numerator/denominator;
    remainder = numerator%denominator;

    printf("Quotient is %d \n Remanider is %d",quotient,remainder);

    return 1;
}
