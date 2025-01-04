#include<stdio.h>

int main()
{
    float num1, num2, result;
    char operationChoice, repeat;


    do
    {
        printf("\nMenu\n");
		printf("\nA : Addition \nS : Subtraction\nM : Multiplication\nD : Division");
		printf("\nWhich operation do you want to execute? \n");
		scanf(" %c", &operationChoice);
		printf("\nEnter two numbers : ");
		scanf("%f%f", &num1, &num2);

		switch(operationChoice)
		{
        case 'A':
        case 'a':
            result = num1 + num2;
            printf("Addition is %.2f",result);
            break;
        case 'S':
        case 's':
            result = num1 - num2;
            printf("Subtraction is %.2f",result);
            break;
        case 'M':
        case 'm':
            result = num1 * num2;
            printf("Multiplication is %.2f",result);
            break;
        case 'D':
        case 'd':
            result = num1 / num2;
            printf("Division is %.2f",result);
            break;
        default:
            printf("\nInvalid choice");
            break;
		}
		printf("\nDo you want to repeat the operations?.. (y/n) \n");
        fflush(stdin);
        scanf("%c",&repeat);

    }while(repeat=='Y' || repeat=='y');

}
