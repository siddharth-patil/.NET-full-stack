#include <stdio.h>
#include<conio.h>

int main(){

    int num1, num2, num3;

    printf("Enter 3 numbers ");
    scanf("%d %d %d",&num1,&num2,&num3);

    int sum = num1 + num2 + num3;

    printf("Sum of 3 numbers is %d.",sum);

    printf("\n Enter 1st letter of your name.");

    char firstLetter = getch();

    printf("1st Letter of your name is %c",firstLetter);

    return 1;
}
