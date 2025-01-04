#include<stdio.h>

int main()
{

    char str[34];
    gets(str);

    int i=0, count=0;

    while(str[i]!='\0')
    {
        if(str[i]==32)
            count++;

        i++;
    }
    printf("Number of spaces in string are: %d",count);

    return 1;
}
