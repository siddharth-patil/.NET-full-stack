#include<stdio.h>

void acceptNumber()
{
    int num;
    printf("Enter a number ");
    scanf("%d",&num);
    printf("You Entered %d.",num);
}

int main()
{
    acceptNumber();

    return 1;
}
