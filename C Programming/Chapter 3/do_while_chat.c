#include <stdio.h>

 int main()
{
    float num1, num2;
    char ch, count;
    float result;
    do
    {
        printf("Menu\n a:add\n s:sub\n m:mul\n d:div\n");
        printf("Enter Choice: ");
        fflush(stdin);
        scanf("%c",&ch);
        printf("Enter two numbers: ");
        scanf("%f %f",&num1,&num2);

        switch(ch)
        {
            case 'A':
            case 'a':
                printf("Addition of num1 and num2 is %0.3f",num1+num2);
                break;

            case 'S':
            case 's':
                printf("Substraction of num1 and num2 is %0.3f",num1-num2);
                break;

            case 'M':
            case 'm':
                printf("Multiplication of num1 and num2 is %0.3f",num1*num2);
                break;

            default:
                printf("\nInvalid Choice!!!\n");
                break;


            case 'D':
            case 'd':
                printf("Division of num1 and num2 is %0.3f",num1/num2);
                break;
        }
        printf("\nDo you want to continue?(y/n) : \n");
		fflush(stdin);
		scanf("%c", &count);
    }while(count=='y' || count=='Y');


}
