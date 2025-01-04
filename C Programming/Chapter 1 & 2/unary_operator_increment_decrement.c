#include<stdio.h>

int main()
{
    //Pre-increment
    int x=3, z;
    z = ++x;
    printf("After Pre-increment z = %d and x = %d \n",z,x);

    //Post-increment
    int a=3,b;
    b = a++;
    printf("After Post-increment b = %d and a = %d \n",b,a);

    //Pre-decrement
    int k=3,l;
    l = --k;
    printf("After Pre-decrement l = %d and k = %d \n",l,k);

    //Post-decrement
    int o=3,p;
    p = o--;
    printf("After Post-decrement p = %d and o = %d",p,o);

    return 1;
}
