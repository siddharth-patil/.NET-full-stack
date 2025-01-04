void checkEvenOdd(int n);

#include<stdio.h>

int main()
{
    int num;

    scanf("%d",&num);

    checkEvenOdd(num);

    return 1;
}

checkEvenOdd(int number)
{
    if(number%2==0)
        printf("%d is EVEN number",number);
    else
        printf("%d is ODD number",number);
}
