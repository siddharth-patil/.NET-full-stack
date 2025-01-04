int Search(int arr[],int num,int arrSize);
#include<stdio.h>

int main()
{
    int arr[5] = {10,23,45,65,90};
    int num, arrSize = 5;
    printf("Enter number to search : ");
    scanf("%d",&num);

    printf("Array elements are : ");
    for(int i = 0; i<arrSize; i++)
    {
        printf("%d ",arr[i]);
    }
    int position = Search(arr,num,arrSize);
    if (position == -1)
    {
       printf("\n%d not found",num);
    }
    else
    {
       printf("\n%d is at position %d.",num,position);
    }
    return 1;
}
Search(int arr[], int num, int arrSize)
{
    if(num<arr[arrSize/2])
    {
        for(int i=0; i<(arrSize/2); i++)
        {
            if(num==arr[i])
                return ++i;
        }
        return -1;
    }
    else
    {
        for(int i=(arrSize/2); i<arrSize; i++)
        {
            if(num==arr[i])
                return ++i;
        }
        return -1;
    }
}
