#include<stdio.h>

int main()
{
    int num, sum = 0;
    printf("Enter a number to add. *(To STOP enter 0)*\n");

    while(1)
    {
        //printf("Enter a number to add. *(To STOP enter 0)*\n");
        scanf("%d",&num);

        if(num==0)
        {
            printf("Sum is : %d",sum);
            break;
        }
        else if(num>0)
        {
            sum = sum + num;
        }
    }

    return 1;
}
