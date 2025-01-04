float calAvgRainfall(float *rainfall, int days);
#include<stdio.h>

int main()
{
    float rainfall[7] = {23.1,43,12,6,8.9,4,5};

    float avgRainfall = calAvgRainfall(rainfall,7);
    printf("Avg Rainfall of a week is %.3f.",avgRainfall);

    return 1;
}

float calAvgRainfall(float *rainfall, int days)
{
    float sum = 0, avgRainfall;

    for(int i=0; i<days; i++)
    {
        sum = sum + *(rainfall + i);
    }

    avgRainfall = sum/days;

    return avgRainfall;
}
