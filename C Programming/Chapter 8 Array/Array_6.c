#include<stdio.h>

int main()
{
    int arr[10] = {1,2,32,121,34};
    int pos, elem;
    printf("Enter the position(from 0 to 9) and element : ");
    scanf("%d%d",&pos,&elem);

    arr[pos] = elem;

    for(int i=0; i<10; i++)
    {
        printf("Element at position/index %d is %d.\n",i,arr[i]);
    }

    return 1;
}
