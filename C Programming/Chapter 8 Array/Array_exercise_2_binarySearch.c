int binarySearch(int arr[], int target);
#include<stdio.h>

int main()
{
    int arr[10] = {1,2,3,4,5,6,7,8,9,10};
    int target;

    printf("Enter number to search : ");
    scanf("%d",&target);
    //printf("%d\n%d\n%d",sizeof(arr),sizeof(arr[0]),(sizeof(arr)/sizeof(arr[0]))-1);
    int position = binarySearch(arr, target);
    if (position == -1)
    {
       printf("\n%d not found",target);
    }
    else
    {
       printf("\n%d is at position %d.",target,position);
    }
    return 1;
}

int binarySearch(int arr[], int target)
{
    int start = 0, end = 9; //(sizeof(arr)/sizeof(arr[0]))-1;

    while(start<=end)
    {
        int mid = (start + end)/2;

        if(target<arr[mid])
            end = mid-1;
        else if (target>arr[mid])
            start = mid + 1;
        else
            return mid+1;
    }
    return -1;
}
