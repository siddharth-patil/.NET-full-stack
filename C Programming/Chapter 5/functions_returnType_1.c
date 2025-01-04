int calcFact();
#include<stdio.h>

int main()
{
    int factorial;

    factorial = calcFact();

    printf("Factorial is %d.",factorial);
}

int calcFact()
{
    int n,fact=1;
    scanf("%d",&n);

    for(int i=2;i<=n;i++)
    {
        fact = fact * i;
    }

    return fact;
}
