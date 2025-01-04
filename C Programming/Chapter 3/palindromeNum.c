#include<stdio.h>

int main()
{
    int num, rem, reverse=0;

    scanf("%d",&num);
    int tempNum =num;
    while(tempNum>0)
    {
        // num= 121

        rem = tempNum%10;

        reverse = reverse*10 + rem;

        tempNum/=10;
    }

    if (reverse==num)
        printf("%d",reverse);
}
