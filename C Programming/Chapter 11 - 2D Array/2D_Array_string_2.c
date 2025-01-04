void displayNames(char names[][15]);

#include <stdio.h>

int main()
{
    int i;
    char names[3][15];

    for(i=0;i<3;i++)
        gets(names[i]);

    displayNames(names);

    return 1;
}

void displayNames(char p[][15])
{
     int i;
     for(i=0;i<3;i++)
        puts(p[i]);
}
