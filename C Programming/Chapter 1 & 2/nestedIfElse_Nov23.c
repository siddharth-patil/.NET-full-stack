#include<stdio.h>

int main(){
    int num;

    printf("Enter a number");
    scanf("%d",&num);

    if(num%2==0)
    {
        if(num%5==0){
            printf("Number is even and divisible by 5.");
        }
        else{
                if(num%4==0)
                {
                   printf("Number is even and divisible by 4 but not divisible by 5.");
                }
                else
                {
                   printf("Number is even and not divisible by 4 as well as 5.");
                }
        }
    }
    else
    {
        if(num%7==0){
            printf("Number is odd and divisible by 7.");
        }
        else{
            printf("Number is odd but not divisible by 7.");
        }
    }

    return 0;
}
