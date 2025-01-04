#include<stdio.h>

int main()
{
    char name[20];
    gets(name);

    for(int i=0; name[i]!='\0'; i++)
    {
        if (!((name[i]>=65 && name[i]<=90) || (name[i]>=97 && name[i]<=122)))
            continue;

        if(name[i]>=65 && name[i]<=90)
            name[i] = name[i]+32;
        else
            name[i] = name[i]-32;
    }

    puts(name);
}
