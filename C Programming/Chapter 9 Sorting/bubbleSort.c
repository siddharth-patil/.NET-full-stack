void bubbleSort(int arr[], int n);
#include<stdio.h>

int main()
{
    int arr[10] = {12,34,567,234,563,66,887,873,34,2};
    int n = (sizeof(arr)/sizeof(arr[0]));
    printf("\Original Array-> ");
    for(int i=0; i<n; i++)
    {
        printf("%d ",arr[i]);
    }

    bubbleSort(arr,n);

    return 1;
}

bubbleSort(int arr[], int n)
{
    int i,j;
    for(i=0; i<n-1; i++)
    {
        for(j=0; j<n-1-i; j++)
        {
            if(arr[j]>arr[j+1])
            {
                int temp = arr[j];
                arr[j] = arr[j+1];
                arr[j+1] = temp;
            }
        }
    }
    printf("\nSorted Array ->  ");
    for(i=0; i<n; i++)
    {
        printf("%d ",arr[i]);
    }
}
