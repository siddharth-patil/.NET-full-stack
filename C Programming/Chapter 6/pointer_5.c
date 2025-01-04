void sum_Odd_Even(int *pSE,int *pSD);
#include<stdio.h>

int main()
{
    int sumEven, sumOdd;

    sum_Odd_Even(&sumEven,&sumOdd);

    printf("Sum of EVEN numbers = %d\n",sumEven);
    printf("Sum of ODD numbers = %d",sumOdd);

    return 1;
}

sum_Odd_Even(int *pSE,int *pSD)
{
    *pSE = 0;
    *pSD = 0;
    for(int i=1;i<=10;i++)
    {
        if(i%2==0)
            *pSE = *pSE + i;
        else
            *pSD = *pSD + i;
    }
}
