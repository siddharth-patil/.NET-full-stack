int a = 5;

#include <stdio.h>

int main()
{
    printf("a = %d\n",a);


    register int i = 10;
    printf("%d\t",i);
    printf("%u",&i);
    return 0;

}
