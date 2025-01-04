#include<stdio.h>

int main()
{
    const int DAY = 7;
    const int CITY = 2;
    int cityTemp[CITY][DAY];
    for(int i=0; i<CITY; i++)
    {
        printf("City %d - \n",i+1);
        for(int j=0; j<DAY; j++)
        {
            printf("\tDay %d temp : ",j+1);
            scanf("%d",&cityTemp[i][j]);
        }
    }

    printf("\n========================\n");
    for(int i=0; i<CITY; i++)
    {
        printf("City %d - \n",i+1);
        for(int j=0; j<DAY; j++)
        {
            printf("\tDay %d temp : ",j+1);
            printf("%d\n",cityTemp[i][j]);
        }
    }
    return 1;
}
