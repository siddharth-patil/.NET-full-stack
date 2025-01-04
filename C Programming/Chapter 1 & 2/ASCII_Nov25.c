#include<stdio.h>

int main()
{
    char ch;

    printf("Enter any character.");
    scanf("%c",&ch);

    if (ch>=48 && ch<=57)
    {
        printf("You entered a digit %c",ch);
    }
    else if (ch>=65 && ch<=90)
    {
        printf("You entered a UPPER case letter %c",ch);
    }
    else if (ch>=97 && ch<=122)
    {
        printf("You entered a LOWER case letter %c",ch);
    }
    else{
        printf("You entered nothing i.e space");
    }

    return 0;

}
