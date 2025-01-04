void calcSquare(int num);
#include<stdio.h>

int main()
{
    int num;
    scanf("%d",&num);

    calcSquare(num);

    return 1;
}

calcSquare(int n)
{
    int sqr = n * n;

    printf("Square of %d is %d.",n,sqr);
}
