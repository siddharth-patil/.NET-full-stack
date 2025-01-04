int strLength1(char str[]);

int strLength2(char *str);

#include<stdio.h>

int main()
{
    char str[10] = "abcde";
    puts(str);
    int length = strLength1(str);
    printf("\nLength of string using subscript operator in argument: %d\n",length);

    length = strLength2(str);
    printf("Length of string using pointer/dereferencing in argument: %d\n",length);
    return 1;

}

strLength1(char str[])
{
    int i=0, count = 0;

    while(str[i]!='\0')
    {
        count++;
        i++;
    }

    return count;
}

strLength2(char *str)
{
    int count=0;

    while(*str!='\0')
    {
        str++;
        count++;
    }
    return count;
}
