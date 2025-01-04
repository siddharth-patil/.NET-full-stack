#include<stdio.h>

int main()
{
    int a,b;
    a=44%3;
    printf("44%%3 = %d",a);

    a=64/3;
    printf("\n64/3 = %d",a);

    a=3*25/5;
    printf("\n3*25/5 = %d",a);

    a = 3;
    b = ++a;
    printf("\nb = %d and a = %d",b,a);

    a = 5;
    b = a++;
    printf("\nb = %d and a = %d",b,a);

    return 1;
}
