#include<stdio.h>

int main()
{
    int arr[5];

    printf("Enter elements in array ");
    for(int i=0; i<5;i++)
    {
        scanf("%d",&arr[i]);
    }

    printf("Original array : ");
    for(int i=0; i<5;i++)
    {
        printf("%d ",arr[i]);
    }


    printf("\nResultant array : ");
    for(int i=0; i<5;i++)
    {
        arr[i] = arr[i]*3;
        printf("%d ",arr[i]);
    }

    return 1;
}
