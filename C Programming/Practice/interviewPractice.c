//#include<stdio.h>
//
//int main()
//{
////    char c = getch();
////    char c = getche();
//
//////    printf("%c",c);
////    int a =9;
////    float b = 6.7;
////    double c = 5.7;
////    char ch ='b';
////
////    printf("%d\n",a%3);
//////    printf("%f",b%2);
//////    printf("%d",c%2);
////    printf("%d",ch%3);
//
//    float  x = 9;
//    float y = 4;
//    int result = (int)x / y;
////    exit(0);
//    printf("%d",result);
//
//    return 1;
//}
#include <stdio.h>

int* getAddress() {
    int localVar = 10;   // Local variable
    return &localVar;    // Returning address of local variable
}

int main() {
    int* ptr = getAddress();   // ptr holds an invalid address
    printf("%d\n", *ptr);      // Undefined behavior
    return 0;
}
