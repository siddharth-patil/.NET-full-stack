void displayAmt(int names[][2]);

#include <stdio.h>

int main()
{

    int fdAmt[3][2],i,j;

    printf("Enter FD amounts\n");
    for(i=0;i<3;i++)
    {
        for(j=0;j<2;j++)
        {
            scanf("%d",&fdAmt[i][j]);
        }
    }

    displayAmt(fdAmt);

    return 0;
}

void displayAmt(int fdAmt[][2])
{
    printf("FD amounts are: \n");
     int row,col;
     for(row=0;row<3;row++)
    {
        for(col=0;col<2;col++)
        {
            printf("%d \t",fdAmt[row][col]);
        }
        printf("\n");
    }
}
