#include<stdio.h>
#include<stdbool.h>

int main()
{
    char str1[20];
    gets(str1);

    int i=0;
    bool trigger = 0;

    while(str1[i]!='\0')
    {
        if(str1[i] == 'a')
        {
            str1[i] ='A';
            trigger++;
        }
        i++;
    }

    if(trigger)
    {
        printf("Character 'a' found in the string. Updated string is: ");
        puts(str1);
    }
    else
    {
        printf("Character 'a' not found in the string.");
        puts(str1);
    }

    return 1;
}
