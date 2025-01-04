#include<stdio.h>

int main()
{

    char name[10];
    /*
    for(int i=0; i<9; i++)
    {
        scanf("%c",&name[i]);
    }
    name[i]='\0';
    for(int i=0; i<11; i++)
    {
        printf("%c",name[i]);
    }

    */
    // scanf("%s",&name);
    // printf("%s",name);

    gets(name);
    puts(name);

    return 1;
}
