#include<stdio.h>

int main()
{
    int a,b,c;

    printf("give 3 numbers");
    scanf("%d %d %d",&a,&b,&c);

    if(a==b)
    {
       if(a==c)
       {
           printf("all numbers are equal");
       }
       else
       {
           printf("all numbers are NOT equal");
       }
    }
    else
    {
        printf("all numbers are NOT equal");
    }

    return 0;
}
