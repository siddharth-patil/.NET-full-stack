#include<stdio.h>

int main()
{
    int i=1;

    while(i<=10)
    {
        printf("%d ",i);
        i++;
    }
    printf("\n");
    i=10;

    while(i>=1)
    {
        printf("%d ",i);
        i--;
    }

    return 1;
}
