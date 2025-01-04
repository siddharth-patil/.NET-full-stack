#include<stdio.h>

int main()
{
    int age;
    char gender;

    printf("Enter age \n");
    scanf("%d",&age);

    printf("Enter gender F or M\n");
    gender = getche();

    if ( ((gender=='m')||(gender=='M')) && age>25 )
    {
        printf("\nEligible for policy 2");
    }
    else if ( ((gender=='f')||(gender=='F')) && age>25 )
    {
        printf("\nEligible for policy 1");
    }
    else
    {
        printf("\nEligible for policy 3");
    }

    return 1;
}
