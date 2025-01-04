#include<stdio.h>

int main()
{
    int rows, i = 1;
    printf("Enter the number of rows: ");
    scanf("%d", &rows);

    do
    {
        int j = 1;

        do
        {
            j++;
            printf("* ");
        }while(j<=i);
        i++;
        printf("\n");
    }while(i<=rows);

    return 1;
}
