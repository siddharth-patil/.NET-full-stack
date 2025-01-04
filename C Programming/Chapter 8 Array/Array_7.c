#include<stdio.h>

int main()
{
    int arr1[3]={1,2,3}, arr2[4]={4,5,6,7};
    int arr3[7];
    int i,j;
    // int arr3[sizeof(arr1)/4+sizeof(arr2)/4];

    // printf("%d %d",sizeof(arr1)/4,sizeof(arr2)/4);

    printf("First array-> ");
    for(i=0; i<3; i++)
    {
        arr3[i] = arr1[i];
        printf("%d ",arr1[i]);
    }

    printf("\nSecond array-> ");
    for(j=0; j<4; j++)
    {
        arr3[i] = arr2[j];
        i++;
        printf("%d ",arr2[j]);
    }

    printf("\nMerged array-> ");
    for(int k=0; k<7; k++)
    {
        printf("%d ",arr3[k]);
    }
}
