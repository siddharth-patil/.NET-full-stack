#include<stdio.h>

int main()
{
    int num1 = 100, num2 = 20;
    printf("\n1.ADD \n2.Multiply \n3.Divide \n4.Subtract ");
    printf("\nEnter a choice : ");

    int ch,ans;
    scanf("%d",&ch);

    switch(ch)
    {
    case 1:
        ans = num1 + num2;
        printf("Addition is %d.",ans);
        break;

    case 2:
        ans = num1 * num2;
        printf("Multiplication is %d.",ans);
        break;

    case 3:
        ans = num1 / num2;
        printf("Division is %d.",ans);
        break;

    case 4:
        ans = num1 - num2;
        printf("Subtraction is %d.",ans);
        break;

    default:
        printf("You entered wrong choice..!");
    }

    return 1;
}
