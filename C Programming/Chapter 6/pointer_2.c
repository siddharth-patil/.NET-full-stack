#include <stdio.h>

int main()
{
    int iNum,*ptr1;
    iNum = 10;
    ptr1 = &iNum;

    printf("\n\nValue of iNum is \t\t\t%d",iNum);  // 10


    printf("\nAddress of iNum is \t\t\t%u",&iNum); // address of iNum

    printf("\n\nValue of ptr is \t\t\t%u",ptr1); // address of iNum

    printf("\n\nValue at address pointed by ptr is \t%d\n",*ptr1);
                                   // value at address(2424..)  = 10

    return 0;
}
