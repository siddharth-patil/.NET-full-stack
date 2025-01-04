int add(int n1, int n2);

#include<stdio.h>

int main()
{
    printf("Enter 2 numbers. ");
    int n1,n2;

    scanf("%d%d",&n1,&n2);

    int addition = add(n1,n2);

    printf("Addition is %d.",addition);

    return 1;
}

int add(int n1, int n2)
{
    return n1+n2;
}
