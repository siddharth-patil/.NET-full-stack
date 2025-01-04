char* strCopy(char destination[],char source[]);

#include<stdio.h>

int main()
{
    char src[15] = "perseverance";
    char dest[20];

    strCopy(dest, src);

    puts(dest);

    return 1;
}

char* strCopy(char destination[], char source[])
{
    int i=0;

    while(source[i]!='\0')
    {
        destination[i] = source[i];
        i++;
    }
    destination[i] = '\0';

    return destination;
}
