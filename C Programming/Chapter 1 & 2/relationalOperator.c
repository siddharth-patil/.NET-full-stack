#include<stdio.h>

int main(){

/*
    int num;

    printf("Enter a number ");
    scanf("%d",&num);

    if(num%2==0){
        printf("%d is an even number.",num);
    }
    else{
        printf("%d is an odd number.",num);
    }
 */

    float balance = 1200000.24, debt_amount;

    printf("Enter amount to Withdraw.");
    scanf("%f",&debt_amount);

    if(debt_amount>balance){
        printf("Your balance is low.Can't withdraw money.");
    }
    else{
        printf("Processing your transaction");
    }


    return 0;
}
