#include<stdio.h>

int main()
{
    int numerator, denominator;

    printf("Enter numerator and denominator");
    scanf("%d %d",&numerator,&denominator);

    if(denominator==0)
    {
        printf("Denominator cann't be zero.");
    }
    else
    {
        float result = (float)numerator/denominator;

        printf("Result is %f",result);
    }

    return 1;
}
