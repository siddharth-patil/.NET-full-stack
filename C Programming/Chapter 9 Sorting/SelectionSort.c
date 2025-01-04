// Algorithm

/*take smallestIndex = 0

initialize 2 for loops one inside another.

For 1st pass of outer for loop 'i' the value at smallestIndex and value at index  'j' of inner for loop will be compared.

if value at index 'j' is samller then the smallestIndex = 'j'

at the end of inner for loop swap the values at samllestIndex and 'i'

increase value of smallestIndex by 1 OR smallestIndex='i' and repeate the process */

#include<stdio.h>

int main()
{
    int arr[5] = {11,4,566,79,398};
    int smallestIndex = 0;

    for(int i=0; i<5; i++)
    {
        smallestIndex=i;
        for(int j=i+1; j<5; j++)
        {
            if(arr[j]<arr[smallestIndex])
                smallestIndex = j;
        }
        if(i!=smallestIndex)
        {
            int temp = arr[i];
            arr[i] = arr[smallestIndex];
            arr[smallestIndex] = temp;
        }

    }
    for(int k=0; k<5; k++)
    {
        printf("%d ",arr[k]);
    }

    return 1;
}
