#include<stdio.h>

int main()
{
    int m1,m2,m3,total;
    float avg;
    printf("Enter marks of m1, m2, m3 ");
    scanf("%d%d%d",&m1,&m2,&m3);

    total = m1+m2+m3;

    //avg = total/3; // Data loss as both operands has int data type.

    //avg = total/3.0; // implicit typecasting - if one operand has float data type then output is float.

    avg = (float) total/3; // explicit typecasting - converting output to float data type explicitly.

    printf("Average of m1, m2, m3 = %f",avg);

    return 1;
}
