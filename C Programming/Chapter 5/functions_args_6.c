void calcCircumference(int radius, float pi);

#include<stdio.h>

int main()
{
    int r;
    const float pi = 3.14;
    printf("Enter radius of circle. ");
    scanf("%d",&r);

    calcCircumference(r,pi);
}

calcCircumference(int r, float pi)
{
    float circumference = 2*pi*r;

    printf("%.3f is Circumference of circle with radius %d",circumference,r);
}
