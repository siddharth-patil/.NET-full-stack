#include<stdio.h>

int main()
{
    int m1[2][2], m2[2][2], rm[2][2];
    int i, j;

    printf("Enter values in Matrix 1\n");
    for(i=0; i<2; i++)
    {
        for(j=0; j<2; j++)
        {
            scanf("%d",&m1[i][j]);
            printf("\n");
        }
    }

    printf("Enter values in Matrix 2\n");
    for(i=0; i<2; i++)
    {
        for(j=0; j<2; j++)
        {
            scanf("%d",&m2[i][j]);
            printf("\n");
        }
    }

    printf("Matrix 1 X Matrix 2 ->\n");
    for(int m1r=0; m1r<2; m1r++) //for(int m1r=0,m2r=0; m1r<2 && m2r<2; m1r++,m2r++)
    {
        for(int m2c=0; m2c<2; m2c++) //for(int m1c=1, m2c=0; m1c<2 && m2c<2; m2c++)
        {
            rm[m1r][m2c] = (m1[m1r][0] * m2[0][m2c]) + (m1[m1r][1] * m2[1][m2c]);
        }
    }

    for(i=0; i<2; i++)
    {
        for(j=0; j<2; j++)
        {
            printf("%d\t",rm[i][j]);
        }
        printf("\n");
    }

    return 1;
}
