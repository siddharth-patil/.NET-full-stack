#include<stdio.h>

int main()
{
    int num, notPrime=0;
    printf("Enter a number ");
    scanf("%d",&num);

    for(int i=1; i<num/2; i++)
    {
        if(num%2==0)
        {
            notPrime++;
            break;
        }
    }

    if(notPrime)
    {
        printf("%d is not a prime number.",num);
    }
    else
    {
        printf("%d is a prime number.",num);
    }

    return 1;
}
