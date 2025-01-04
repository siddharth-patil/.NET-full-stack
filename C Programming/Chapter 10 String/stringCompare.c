#include<stdio.h>

int main()
{
    char str1[10] = "abcde";
    char str2[10] = "abcde";
    char str3[10] = "abCde";

    int a = strcmp(str1, str2);
    if (a==0)
        printf("str1 and str2 are similar\n");

    //int b = strcmp(str1,str3);
    int b = strcmp(str3,str1);
    if(b==1)
        printf("str1 is greater than str3 i.e %d.\n",b);
    else if(b==-1)
        printf("Str3 is smaller i.e %d",b);

    return 0;

}
