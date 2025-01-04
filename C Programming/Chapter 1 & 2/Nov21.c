#include <stdio.h>

int main(){

    int x = 99, y = 12;
    int z = x + y;

    // using expression directly
    printf("Addition of %d and %d is %d \n",x,y,x+y);
    // storing value of expression in another variable and then printing
    printf("Addition  of %d and %d is %d",x,y,z);

    return 1;
}
