#include<stdio.h>

int main()
{
    char arr[4][10] = {
                        "abcde",
                        "abc",
                        "adhjasd",
                        "asdfghjkl"
                        };

    for(int i=0; i<4; i++)
    {
        puts(arr[i]);
    }

    return 1;
}
