#include<stdio.h>

int main()
{
    float rainfall[7], sumOfRainfall = 0, avgRainfall;

    printf("Enter 7 days rainfall in mm: ");
    for(int i=0; i<7; i++)
    {
        scanf("%f",&rainfall[i]);
    }

    for(int j=0; j<7; j++)
    {
        sumOfRainfall = sumOfRainfall + rainfall[j];
    }

    avgRainfall = sumOfRainfall/7;
    printf("Average rainfall of a week is: %.3f",avgRainfall);

    return 1;
}
