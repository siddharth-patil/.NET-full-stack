#include<stdio.h>
#include<stdlib.h>

int main()
{
    int noOfElem;
    int *ptr, i;

    printf("\nEnter number of element:");
    scanf("%d",&noOfElem);

    ptr = (int*) calloc(noOfElem, sizeof(int));

    printf("\nptr = %u",ptr);
    printf("\nValues before initializing are\n");

    for(int i=0; i<noOfElem; i++)
    {
        printf("\n%d", *(ptr + i));//ptr[i]
    }

    printf("\nEnter elements: ");

    for(int i=0; i<noOfElem; i++)
    {
        scanf("%d",&ptr[i]);//(ptr + i)
    }

    for (int i = 0; i<noOfElem; i++)
	{
		printf("\n%d", *(ptr + i));//ptr[i]

		printf("\t%u", (ptr + i));
	}

	return 0;

}
