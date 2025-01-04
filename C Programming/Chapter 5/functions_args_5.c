void calcMax(int num1, int num2);
#include<stdio.h>

int main()
{
    int n1, n2;
    scanf("%d%d",&n1,&n2);

    calcMax(n1,n2);

    return 1;
}

calcMax(int num1, int num2)
{
    num1>num2 ? printf("%d is greater",num1) : printf("%d is greater",num2);
}
