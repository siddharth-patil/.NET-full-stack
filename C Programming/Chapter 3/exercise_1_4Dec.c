#include<stdio.h>

int main()
{
    int num, count;

    while(1)
    {
        printf("Enter a number : ");
        scanf("%d",&num);

        if(num==0)
            break;
        else
            if (num%5==0)
                printf("%d \n",num);
    }

    return 1;
}
