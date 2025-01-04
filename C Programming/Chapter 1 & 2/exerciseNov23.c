#include<stdio.h>

int main(){

    int cost_price, selling_price;

    printf("Enter cost price");
    scanf("%d",&cost_price);

    printf("Enter selling price");
    scanf("%d",&selling_price);



    if(cost_price > selling_price){
        int loss = cost_price - selling_price;
        printf("Loss is Rs %d.",loss);
    }
    else{
        int profit = selling_price - cost_price;
        printf("Profit is Rs %d.",profit);
    }

    return 0;
}
