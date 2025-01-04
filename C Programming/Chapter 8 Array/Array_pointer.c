#include<stdio.h>

int main()
{
    int arr[5] = {10,20,30,40,50};
    int  *p1,*p2;

    p1 = &arr[0]; // 100
    p2 = &arr[2]; //


    printf("Pointer1\t = %d\t ",*(++p1));

   /* *(++p1)
    value at address(p1+1)
    value at address(p1+1)
    */
    printf("Pointer2\t = %u\n \n",p2);

    p2 = p1;

    printf("After Assignment\n\n");

    printf("Pointer1\t = %u\t ",p1);
    printf("Pointer2\t = %u\n\n ",p2);

    p2 = p2 + 3;
    printf("After Increment\n\n");


    printf("Pointer2\t = %u\n\n ",p2);

    p1++;

    printf("After Increment\n\n");


    printf("Pointer1\t = %u\n\n ",p1);

    p1--;

    printf("After Decrement\n\n");


    printf("Pointer1\t = %u\n\n ",p1);


    p2 = p2 - 2;

    printf("After Decrement\n\n");


    printf("Pointer2\t = %u\n\n ",p2);

    int how_far = p2 - p1;

    printf("How far \t = %d elements\n\n ",how_far);

    return 1;
}
