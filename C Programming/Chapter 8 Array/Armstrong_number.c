#include<stdio.h>

int main()
{
    int num, temp, remainder, totalDigits=0, finalNum = 0, total = 1;

    printf("Enter a number ");
    scanf("%d",&num);

    temp = num;
    while(temp>0)
    {
        remainder = temp%10;
        totalDigits++;
        temp /= 10;
    }

    temp = num;
    while(temp>0)
    {
        total=1;
        remainder = temp%10;
        for(int i = 1; i<=totalDigits; i++)
        {
                total *= remainder;
        }
        finalNum = finalNum + total;
        temp /= 10;
    }

    if (finalNum == num)
        printf("%d is Armstrong number.",num);
    else
        printf("%d is not an Armstrong number.",num);

    return 1;
}
