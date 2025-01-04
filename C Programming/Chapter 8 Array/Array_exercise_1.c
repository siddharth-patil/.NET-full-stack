//int findMaximum(int arr[]);
int findMaximum(int *arr);
#include<stdio.h>

int main()
{
    int arr[4] = {1,123,432,-43};
    //int *pARR = &arr
    int max = findMaximum(arr);

    printf("%d is bigger number in an Array.",max);

}

/*findMaximum(int arr[])
{
    int max = arr[0];
    for(int i=1; i<4; i++)
    {
        if (arr[i]>max)
            max = arr[i];
    }
    return max;
}*/
int findMaximum(int *arr)
{
    int max = *arr;;
    for(int i=1; i<4; i++)
    {
        if (*(arr+i)>max)
            max = *(arr+i);
    }
    return max;
}
