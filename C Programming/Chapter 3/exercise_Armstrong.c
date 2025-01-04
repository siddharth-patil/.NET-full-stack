#include<stdio.h>

int main()
{
    int num, exponent, power, base, sum;

    printf("Armstrong numbers from 100 to 1000 are : \n");

    for(num = 100; num<=1000; num++)
    {
        exponent = 0;
        power = 1;
        sum = 0;
        //count of digits in a given number
        int tempNum = num;
        while(tempNum>0)
        {
            exponent++;

            tempNum/=10;
        }
      //printf("%d",count);

        //calculating power of each digit and adding it
        tempNum = num;
        while(tempNum>0)
        {
            base = tempNum%10;
            tempNum/=10;
            power = 1;
            if (base==0)
                continue;

            for(int i=1; i<=exponent;i++)
            {
                power = power * base;
            }
            sum = sum + power;

        }

        if (sum==num)
            printf("%d ",num);
    }

    return 1;
}
