#include<stdio.h>

int main()
{
    int num,isPrime;

    for(num=2; num<=100; num++)
    {
        isPrime=1;
        for(int i=2; i<=num/2; i++)
        {
            if(num%i==0)
            {
                isPrime = 0;
                break;
            }
            else
                continue;

        }
        if (isPrime)
            printf("%d\n",num);
    }

    return 1;
}
