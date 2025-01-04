#include<stdio.h>

int main()
{
    int day, month, year;
    printf("Enter a date : ");
    scanf("%d/%d/%d", &day, &month, &year);

    switch(month)
    {
    case 01:
        printf("January has 31 days.");
        break;
    case 02:
            if((year%4==0 && year%100!=0) ||(year%400==0))
                printf("February has 29 days.");
            else
                printf("February has 28 days");

            break;
    case 03:
    case 11:
        printf("November has 30 days.");
        break;
    case 12:
        printf("December has 31 days.");
        break;
    default:
        printf("Month doesn\'t exist.");
    }
}
