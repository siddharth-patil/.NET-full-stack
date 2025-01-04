#include<stdio.h>

int main()
{
    float a=18,b=4;
    float result, remainder;

    result = a/b;
    remainder = a%b;

    printf("Division is %f",result);
    printf("Remainder is %f",remainder);

    return 1;
}
