#include<stdio.h>

int main()
{
    char name[12];

    gets(name);

    int count=0;

    while(name[count]!='\0')
    {
        count++;
    }

    for(int i=count-1; i>=0; i--)
    {
        printf("%c ",name[i]);
    }
}
