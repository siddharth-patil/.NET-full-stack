int findMax(int n1, int n2);

#include<stdio.h>

int main()
{
    int n1,n2;
    scanf("%d%d",&n1,&n2);

    int max = findMax(n1,n2);

    printf("Maximum is %d.",max);

    return 1;
}

findMax(int n1, int n2)
{
    if (n1>n2)
        return n1;
    else
        return n2;
}
