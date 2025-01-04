#include<stdio.h>

int main()
{
    int num, total = 0;
    scanf("%d",&num);
    for(int i=1; i<=num; i++)
    {
        if(i%2!=0)
        {
            printf("%d\n",i);
            total = total + i;
        }
    }
    printf("Total = %d ",total);

    return 1;
}
