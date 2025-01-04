#include<stdio.h>

int main()
{
    printf("Enter a number : ");
    int num, factorial = 1;
    scanf("%d",&num);

    if(num==0)
    {
        printf("Factorial of 0 is 1");
    }
    else
    {
        for (int i = num; i>=1; i--)
        {
            factorial = i * factorial;
        }

        printf("Factorial of %d is %d",num,factorial);
    }

    return 1;
}
