void insertValue(int arr[], int num, int position);
#include<stdio.h>

int main()
{
    int arr[10] = {12,23,34,13,45};
    int num,pos;
    printf("Enter value to insert in an Array: ");
    scanf("%d",&num);
    printf("At what position do you want to insert: ");
    scanf("%d",&pos);
    if(pos>10)
    {
        printf("Position should be less than 10. Enter position again");
        scanf("%d",&pos);
    }

    printf("\nOriginal array--> ");
    for(int i=0; i<10; i++)
    {
        printf("%d ",arr[i]);
    }

    insertValue(arr, num, pos);

    return 1;
}

void insertValue(int arr[], int num, int position)
{
    arr[position-1] = num;
    printf("\nUpdated array--> ");
    for(int i=0; i<10; i++)
    {
        printf("%d ",arr[i]);
    }
}
