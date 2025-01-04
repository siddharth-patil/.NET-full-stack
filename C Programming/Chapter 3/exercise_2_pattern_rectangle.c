#include<stdio.h>

int main()
{
    printf("Enter rows and columns ");
    int row,col;
    scanf("%d %d",&row,&col);

    for(int i=1; i<=row; i++)
    {
        for(int j=1; j<=col; j++)
        {
            printf("1 ");
        }
        printf("\n");
    }

    return 1;
}
