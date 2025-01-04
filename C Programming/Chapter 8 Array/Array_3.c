#include<stdio.h>

int main()
{
    int arr[4], max;

    for(int i=0; i<4; i++)
    {
        scanf("%d",&arr[i]);
    }
    max = arr[0];
    for(int j=0; j<4; j++)
    {
        if(arr[j]>max)
            max = arr[j];
    }
    printf("%d is greater.",max);

    return 1;
}
