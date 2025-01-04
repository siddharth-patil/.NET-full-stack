int stringCompare(char str1[], char str2[]);

#include<stdio.h>
#include<string.h>

int main()
{
    char str1[20] = "Abc";
    char str2[20] = "abc";
    puts(str1); puts(str2);
    int res = stringCompare(str1, str2);
    if(res)
    {
        printf("Strings are NOT SIMILAR");
    }
    else{
        printf("Strings are SIMILAR");
    }

    return 1;
}

int stringCompare(char str1[], char str2[])
{
    if(strlen(str1)!=strlen(str2))
        return 1;

    int i=0;

    while(str1[i]!='\0')
    {
        if (str1[i] == str2[i])
            continue;
        else
            {
//                printf("Both strings are not similar");
//                break;
                return 1;
            }
        i++;

    }
    return 0;
//    if(str2[i]=='\0')
//        return 0; //printf("%s and %s both are similar.",str1,str2);
}
