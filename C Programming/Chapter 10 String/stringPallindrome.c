
#include<stdio.h>
#include<string.h>

int main()
{
    char str1[20] = "abcdcba";
    char str2[20];

    strcpy(str2,str1);
    strrev(str2);

    if (strcmp(str1,str2) == 0)
        printf("%s is palindrome.",str1);
    else
        printf("%s is not a palindrome",str1);

    return 1;
}
