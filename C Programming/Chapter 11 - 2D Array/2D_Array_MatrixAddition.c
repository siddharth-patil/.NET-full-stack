#include<stdio.h>

int main()
{
    float mtrx1[2][2], mtrx2[2][2], rMtrx[2][2];
    int i,j;
    //Taking input for Matrix 1
    printf("Matrix 1->\n");
    for(i=0; i<2; i++)
    {
        for(j=0; j<2; j++)
        {
            printf("\tr%d-c%d = ",i,j);
            scanf("%f",&mtrx1[i][j]);
        }
    }
    //Taking input for Matrix 2
    printf("Matrix 2->\n");
    for(i=0; i<2; i++)
    {
        for(j=0; j<2; j++)
        {
            printf("\tr%d-c%d = ",i,j);
            scanf("%f",&mtrx2[i][j]);
        }
    }

    //Storing addition of Matrix 1 and Matrix 2 in rMtrx
    printf("Addition->\n");
    for(i=0; i<2; i++)
    {
        for(j=0; j<2; j++)
        {
            rMtrx[i][j] = mtrx1[i][j] + mtrx2[i][j];

            //Displaying Addition of Matrix 1 and Matrix 2
            printf("\tr%d-c%d = %.1f\n",i,j,rMtrx[i][j]);
        }
    }

    return 1;
}







