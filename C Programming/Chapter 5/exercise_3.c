#include<stdio.h>
#include<stdbool.h>

bool isAlphbet(char ch);

int main()
{
    char ch;
    scanf("%c",&ch);

    bool ans = isAlphbet(ch);

    if (ans)
        printf("%c is alphabet.",ch);
    else
        printf("%c is NOT alphabet.",ch);\

    return 1;
}

bool isAlphbet(char ch)
{
    if((ch>=65 && ch<=90)||(ch>=97 && ch<=122))
        return 1;
    else
        return 0;
}
