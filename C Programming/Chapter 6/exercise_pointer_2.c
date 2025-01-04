void circleAreaCircum(float r, float *A, float *C);
#include<stdio.h>

int main()
{
    float radius, area, circumference;
    printf("Enter radius of circle ");
    scanf("%f",&radius);
    circleAreaCircum(radius, &area, &circumference);

    printf("Area = %.3f, Circumference = %.3f",area,circumference);

    return 1;
}

circleAreaCircum(float r, float *A, float *C)
{
    *A = 3.14 * r * r;
    *C = 2 * 3.14 * r;
}
