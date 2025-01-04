#include<stdio.h>

int main()
{
    int arr[4],revArr[4];

    printf("Enter 4 elements : ");
    for(int i=0; i<4; i++)
    {
        scanf("%d",&arr[i]);
    }

    for(int i=0,j=3; i<4; i++,j--)
    {
        revArr[i] = arr[j];
    }
    printf("Reverse array elements :\n");
    for(int i=0; i<4; i++)
    {
        printf("%d ",revArr[i]);
    }

}
