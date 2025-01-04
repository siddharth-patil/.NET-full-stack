void calcFactorial(int n);
#include<stdio.h>

int main()
{
    int num;
    scanf("%d",&num);

    calcFactorial(num);

    return 1;
}

calcFactorial(int n)
{
    int fact = 1;

    for(int i=2;i<=n;i++)
    {
        fact = fact*i;
    }

    printf("Factorial of %d is %d. ",n,fact);
}
