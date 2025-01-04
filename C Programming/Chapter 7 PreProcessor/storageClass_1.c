void test();

#include <stdio.h>

int main()
{
     test();
     test();
     test();
     return 1;

}

void test()
{
    static int stat_var = 10;
    int x = 10;
    stat_var++;  // 11   12  13
    x++; // 11  11  11
	printf("x = %d, stat_var = %d\n", x, stat_var);

}
