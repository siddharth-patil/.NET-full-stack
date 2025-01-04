#include<stdio.h>

int main()
{
    char name[15];

    gets(name);
    int i =0,count=0;

    while(name[i]!='\0')
    {
        if((name[i]=='a') || (name[i]=='e') || (name[i]=='i') || (name[i]=='o') || (name[i]=='u') || (name[i]=='A') || (name[i]=='E') || (name[i]=='I') || (name[i]=='O') || (name[i]=='U'))
            count++;

        i++;
    }
    printf("Vowel Count : %d",count);

    return 1;
}
