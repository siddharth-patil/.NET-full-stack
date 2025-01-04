float calcAreaOfCircle(int r);
#include<stdio.h>

int main()
{
    printf("Enter radius ");
    int radius;
    scanf("%d",&radius);

    float area = calcAreaOfCircle(radius);

    printf("Area of circle with radius %d is %.3f",radius,area);
}

float calcAreaOfCircle(int r)
{
    const float pi = 3.14;

    float area = pi * r * r;

    return area;
}
