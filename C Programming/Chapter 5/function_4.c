void printPattern(int rows);
#include<stdio.h>

int main()
{
    printf("Enter rows ");
    int rows;
    scanf("%d",&rows);

    printPattern(rows);

    return 1;
}

printPattern(int rows)
{
//    main();
    if (rows==1)
        return;

    for(int j=1; j<=rows; j++)
    {
        for(int i=1; i<=j; i++)
        {
            printf("* ");
        }
        printf("\n");
    }
}
