void divisionFun(int n, int d, int *q, int *r);
#include<stdio.h>

int main()
{
    int numerator, denominator, quotient, remainder;
    printf("Enter numerator and denominator ");
    scanf("%d%d",&numerator,&denominator);

    while(denominator == 0)
    {
        printf("denominator must be different than 0\n");
        printf("Enter denominator again ");
        scanf("%d",&denominator);
        if (denominator !=0)
            break;
    }

    divisionFun(numerator,denominator,&quotient,&remainder);

    printf("Quotient = %d, Remainder = %d",quotient,remainder);

    return 1;
}

divisionFun(int n,int d, int *q, int *r)
{
    *q = n/d;

    *r = n%d;
}
