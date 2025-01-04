char strConcat(char dest[], char src[]);

#include<stdio.h>
#include<string.h>

int main()
{
    char dest[20] = "siddharth_";
    char src[10] = "patil";

    strConcat(dest,src);

    puts(dest);

    return 1;
}

char strConcat(char dest[], char src[])
{
    int destLength = strlen(dest);
    int i = 0;

    while(src[i]!='\0')
    {
        dest[destLength] = src[i];
        i++;
        destLength++;
    }

    return dest;
}
