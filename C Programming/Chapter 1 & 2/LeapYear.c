#include<stdio.h>

int main()
{
    printf("Enter a year : ");
    int year;
    scanf("%d",&year);

    if( (year%4==0 && year%100!=0) || (year%400==0) )
        printf("Leap Year");
    else
        printf("Not a Leap Year");

    return 1;
}