 #include<stdio.h>

int main()

{

    int b = 25, c = 15, d = 38, e = 58, a;

    a = b > c   ?    c > d   ?   12   :   d > e   ?    13 : 14 : 15 ;

    printf(" %d ", a);

    return 0;

}
