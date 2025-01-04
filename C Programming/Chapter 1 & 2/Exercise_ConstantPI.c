#include<stdio.h>

int main()
{
    const float pi = 3.14;

    int r;

    printf("Enter radius ");
    scanf("%d",&r);

    float area = pi * r * r;

    printf("Area of circle is %f",area);

    return 1;
}
