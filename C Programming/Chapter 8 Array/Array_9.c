int Search(int arr[],int element);

#include<stdio.h>
int main()
{
	int arr[5] = {10,3,2,60,6},no,pos;

	printf("\nEnter an element to search \t");
	scanf("%d",&no);

	pos = Search(arr,no);

	if(pos == -1)
        printf("Element Not Found");
	else
        printf("Found at %d position",pos+1);

	return 0;
}

int Search(int arr[],int element)
{
    int i;

	for (i = 0; i<5; i++)
	{
	    if(element == arr[i])
            return i;
    }
    if(i == 5)
        return -1;
    }
