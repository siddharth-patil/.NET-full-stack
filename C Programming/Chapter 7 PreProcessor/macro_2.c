#define NEWLINE "\n\n"
#define COUNTRY "INDIA"
#define PI 3.14
#define SQUARE(a) (a)*(a)
#define CUBE(a) SQUARE(a) * (a)

#include<stdio.h>

int main()
{
    printf(NEWLINE);

    #ifdef COUNTRY
    printf("%s is My Country.\n",COUNTRY);
    #endif // COUNTRY

    #ifndef COUNTRY
    printf("Your country is not defined");
    #endif // COUNTRY
    float r = 3;
    printf("Area of circle is %.3f\n",PI*r*r);

    printf("Square of 5 =%d \n",SQUARE(5));
    printf("Square of 5 =%d \n",SQUARE(3+2));
    printf("Cube of 5 =%d ",CUBE(5));
}
