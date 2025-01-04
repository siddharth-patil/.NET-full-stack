#include<stdio.h>

int main()
{
   char name[10]; // = {'N','I','K','H','I','L'};
   // int name[10] = {1,2,4,5,9,6};

    gets(name);
    int i = 0;
    /*
    for(int i=0; i<10; i++)
    {
        printf("%d ",name[i]);
    }
    */


    while(name[i]!='\0')
    {
        printf("%c\t",name[i]);

        i = i+2;
    }

}
