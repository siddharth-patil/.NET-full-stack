#include<stdio.h>

int main()
{
    int x = 300,*px;
    px = &x;

    printf("Value of x = %d.\n",x);
    printf("Value of address of x = %u.\n",px);
    printf("Value of x by using pointer = %d.\n",*px);


    float y = 234.43,*py;
    py = &y;

    printf("Value of y = %f.\n",y);
    printf("Value of address of y = %u.\n",py);
    printf("Value of y by using pointer = %f.\n",*py);

    double z = 412.97, *pz;
    pz = &z;

    char c = 'S', *pc;
    pc = &c;

    printf("%d\n",sizeof(px));
    printf("%d\n",sizeof(py));
    printf("%d\n",sizeof(pz));
    printf("%d\n",sizeof(pc));


    return 1;

}
